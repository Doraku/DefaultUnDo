using System;
using System.Collections.Generic;
using DefaultUnDo.Technical;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class ICollectionExtension
    {
        #region Methods

        /// <summary>
        ///  Wraps an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
        /// <param name="source">The <see cref="ICollection{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>, the name of the method called is passed as a parameter.</param>
        /// <returns>A wrapped <see cref="ICollection{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static ICollection<T> AsUnDo<T>(this ICollection<T> source, IUnDoManager manager, Func<string, string> descriptionFactory = null) => new UnDoCollection<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)),
            descriptionFactory);

        #endregion
    }
}
