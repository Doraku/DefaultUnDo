﻿using System;
using System.Collections.Generic;
using DefaultUnDo.Internal;

namespace DefaultUnDo;

/// <summary>
/// Provides a method to wrap an <see cref="IDictionary{TKey, TValue}"/> to an UnDo dictionary linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
/// </summary>
public static class IDictionaryExtensions
{
    /// <summary>
    ///  Wraps an <see cref="IDictionary{TKey, TValue}"/> to an UnDo dictionary linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    /// <typeparam name="TKey">The type of keys.</typeparam>
    /// <typeparam name="TValue">The type of values.</typeparam>
    /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/>.</param>
    /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
    /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>.</param>
    /// <returns>A wrapped <see cref="IDictionary{TKey, TValue}"/>.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
    public static IDictionary<TKey, TValue> AsUnDo<TKey, TValue>(this IDictionary<TKey, TValue> source, IUnDoManager manager, Func<UnDoCollectionOperation, object?>? descriptionFactory = null)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(manager);

        return new UnDoIDictionary<TKey, TValue>(
            manager,
            source,
            descriptionFactory);
    }
}
