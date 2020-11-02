using System;
using System.Collections.Generic;
using DefaultUnDo.Technical;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="ISet{T}"/> to an UnDo set linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class ISetExtension
    {
        #region Methods

        /// <summary>
        ///  Wraps an <see cref="ISet{T}"/> to an UnDo set linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ISet{T}"/>.</typeparam>
        /// <param name="source">The <see cref="ISet{T}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
        /// <returns>A wrapped <see cref="ISet{T}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static ISet<T> AsUnDo<T>(this ISet<T> source, IUnDoManager manager, Func<UnDoCollectionOperation, object> descriptionFactory = null) => new UnDoISet<T>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)),
            descriptionFactory);

        #endregion
    }
}
