using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DefaultUnDo.Technical;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="IList{T}"/> to an UnDo list linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class IListExtension
    {
        #region Methods

        /// <summary>
        ///  Wraps an <see cref="IList{T}"/> to an UnDo list linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="source">The <see cref="IList{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
        /// <returns>A wrapped <see cref="IList{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static IList<T> AsUnDo<T>(this IList<T> source, IUnDoManager manager, Func<UnDoCollectionOperation, object> descriptionFactory = null) => new UnDoList<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)),
            descriptionFactory);

        /// <summary>
        /// Moves the item at the specified index to a new location in the collection.
        /// If <paramref name="source"/> is an UnDo list and its inner source an <see cref="ObservableCollection{T}"/>, it will use the <see cref="ObservableCollection{T}.Move(int, int)"/> method;
        /// else it will do an <see cref="IList{T}.RemoveAt(int)"/> and <see cref="IList{T}.Insert(int, T)"/>.
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
