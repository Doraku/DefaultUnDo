using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class ICollectionExtension
    {
        #region Types

        internal class UnDoCollection<T> : ICollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
        {
            #region Fields

            private readonly ICollection<T> _source;

            protected readonly IUnDoManager _manager;

            #endregion

            #region Initialisation

            public UnDoCollection(IUnDoManager manager, ICollection<T> source)
            {
                _manager = manager;
                _source = source;
            }

            #endregion

            #region ICollection

            void ICollection<T>.Add(T item) => _manager.DoAdd(_source, item);

            void ICollection<T>.Clear() => _manager.DoClear(_source);

            bool ICollection<T>.Contains(T item) => _source.Contains(item);

            void ICollection<T>.CopyTo(T[] array, int arrayIndex) => _source.CopyTo(array, arrayIndex);

            int ICollection<T>.Count => _source.Count;

            bool ICollection<T>.IsReadOnly => _source.IsReadOnly;

            bool ICollection<T>.Remove(T item) => _manager.DoRemove(_source, item);

            #endregion

            #region IEnumerator

            IEnumerator<T> IEnumerable<T>.GetEnumerator() => _source.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_source).GetEnumerator();

            #endregion

            #region INotifyCollectionChanged

            event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
            {
                add
                {
                    if (_source is INotifyCollectionChanged collection)
                    {
                        collection.CollectionChanged += value;
                    }
                }
                remove
                {
                    if (_source is INotifyCollectionChanged collection)
                    {
                        collection.CollectionChanged -= value;
                    }
                }
            }

            #endregion

            #region INotifyPropertyChanged

            event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
            {
                add
                {
                    if (_source is INotifyPropertyChanged collection)
                    {
                        collection.PropertyChanged += value;
                    }
                }
                remove
                {
                    if (_source is INotifyPropertyChanged collection)
                    {
                        collection.PropertyChanged -= value;
                    }
                }
            }

            #endregion
        }

        #endregion

        #region Methods

        /// <summary>
        ///  Wraps an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
        /// <param name="source">The <see cref="ICollection{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <returns>A wrapped <see cref="ICollection{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static ICollection<T> AsUnDo<T>(this ICollection<T> source, IUnDoManager manager) => new UnDoCollection<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)));

        #endregion
    }
}
