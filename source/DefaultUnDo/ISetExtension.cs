using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="ISet{T}"/> to an UnDo set linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class ISetExtension
    {
        #region Types

        private class UnDoSet<T> : ICollectionExtension.UnDoCollection<T>, ISet<T>
        {
            #region Fields

            private readonly ISet<T> _source;

            #endregion

            #region Initialisation

            public UnDoSet(IUnDoManager manager, ISet<T> source, Func<string, string> descriptionFactory)
                : base(manager, source, descriptionFactory)
            {
                _source = source;
            }

            #endregion

            #region ISet

            bool ISet<T>.Add(T item) => _manager.DoAdd(_source, item, _descriptionFactory?.Invoke(nameof(ISet<T>.Add)));

            void ISet<T>.ExceptWith(IEnumerable<T> other)
            {
                if (_source.Count > 0)
                {
                    using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.ExceptWith))))
                    {
                        foreach (T item in other)
                        {
                            _manager.DoRemove(_source, item);
                        }
                    }
                }
            }

            void ISet<T>.IntersectWith(IEnumerable<T> other)
            {
                if (_source.Count > 0)
                {
                    List<T> items = other.Where(_source.Contains).ToList();

                    using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.IntersectWith))))
                    {
                        _manager.DoClear(_source);
                        foreach (T item in items)
                        {
                            _manager.DoAdd(_source, item);
                        }
                    }
                }
            }

            bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other) => _source.IsProperSubsetOf(other);

            bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other) => _source.IsProperSupersetOf(other);

            bool ISet<T>.IsSubsetOf(IEnumerable<T> other) => _source.IsSubsetOf(other);

            bool ISet<T>.IsSupersetOf(IEnumerable<T> other) => _source.IsSupersetOf(other);

            bool ISet<T>.Overlaps(IEnumerable<T> other) => _source.Overlaps(other);

            bool ISet<T>.SetEquals(IEnumerable<T> other) => _source.SetEquals(other);

            void ISet<T>.SymmetricExceptWith(IEnumerable<T> other)
            {
                using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.SymmetricExceptWith))))
                {
                    foreach (T item in other)
                    {
                        if (!_manager.DoRemove(_source, item))
                        {
                            _manager.DoAdd(_source, item);
                        }
                    }
                }
            }

            void ISet<T>.UnionWith(IEnumerable<T> other)
            {
                using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.UnionWith))))
                {
                    foreach (T item in other)
                    {
                        _manager.DoAdd(_source, item);
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Methods

        /// <summary>
        ///  Wraps an <see cref="ISet{T}"/> to an UnDo set linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ISet{T}"/>.</typeparam>
        /// <param name="source">The <see cref="ISet{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>, the name of the method called is passed as a parameter.</param>
        /// <returns>A wrapped <see cref="ISet{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static ISet<T> AsUnDo<T>(this ISet<T> source, IUnDoManager manager, Func<string, string> descriptionFactory = null) => new UnDoSet<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)),
            descriptionFactory);

        #endregion
    }
}
