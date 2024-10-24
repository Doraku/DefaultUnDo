﻿using System;
using System.Collections.Generic;
using DefaultUnDo.Internal;

namespace DefaultUnDo;

/// <summary>
/// Provides a method to wrap an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
/// </summary>
public static class ICollectionExtensions
{
    /// <summary>
    ///  Wraps an <see cref="ICollection{T}"/> to an UnDo collection linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
    /// <param name="source">The <see cref="ICollection{T}"/>.</param>
    /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
    /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
    /// <returns>A wrapped <see cref="ICollection{T}"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
    public static ICollection<T> AsUnDo<T>(this ICollection<T> source, IUnDoManager manager, Func<UnDoCollectionOperation, object?>? descriptionFactory = null)
    {
        ArgumentNullException.ThrowIfNull(manager);
        ArgumentNullException.ThrowIfNull(source);

        return new UnDoICollection<T>(
            manager,
            source,
            descriptionFactory);
    }
}
