using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="IList{T}"/> to an UnDo list linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class IListExtension
    {
        #region Types

        private class UnDoList<T> : ICollectionExtension.UnDoCollection<T>, IList<T>
        {
            #region Fields

            private readonly IList<T> _source;

            #endregion

            #region Initialisation

            public UnDoList(IUnDoManager manager, IList<T> source)
                : base(manager, source)
            {
                _source = source;
            }

            #endregion

            #region Methods

            public void Move(int oldIndex, int newIndex)
            {
                if (_source is ObservableCollection<T> collection)
                {
                    _manager.Do(
                        () => collection.Move(oldIndex, newIndex),
                        () => collection.Move(newIndex, oldIndex));
                }
                else
                {
                    using (_manager.BeginGroup())
                    {
                        T item = _source[oldIndex];
                        IList<T> list = this;
                        list.RemoveAt(oldIndex);
                        list.Insert(newIndex, item);
                    }
                }
            }

            #endregion

            #region IList

            int IList<T>.IndexOf(T item) => _source.IndexOf(item);

            void IList<T>.Insert(int index, T item) => _manager.DoInsert(_source, index, item);

            void IList<T>.RemoveAt(int index) => _manager.DoRemoveAt(_source, index);

            T IList<T>.this[int index]
            {
                get => _source[index];
                set => _manager.Do(_source, index, value);
            }

            #endregion
        }

        #endregion

        #region Methods

        /// <summary>
        ///  Wraps an <see cref="IList{T}"/> to an UnDo list linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IList{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <returns>A wrapped <see cref="IList{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static IList<T> AsUnDo<T>(this IList<T> source, IUnDoManager manager) => new UnDoList<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)));

        /// <summary>
        /// Moves the item at the specified index to a new location in the collection.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IList{T}"/> on which to perform the move.</param>
        /// <param name="oldIndex">The zero-based index specifying the location of the item to be moved.</param>
        /// <param name="newIndex">The zero-based index specifying the new location of the item.</param>
        public static void Move<T>(this IList<T> source, int oldIndex, int newIndex)
        {
            if (source is UnDoList<T> undo)
            {
                undo.Move(oldIndex, newIndex);
            }
            else
            {
                T item = source[oldIndex];
                source.RemoveAt(oldIndex);
                source.Insert(newIndex, item);
            }
        }

        #endregion
    }
}
