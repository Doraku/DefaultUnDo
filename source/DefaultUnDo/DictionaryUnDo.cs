﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo;

/// <summary>
/// Provides an implementation of the <see cref="IUnDo"/> interface for <see cref="IDictionary{TKey, TValue}"/> operation.
/// </summary>
/// <typeparam name="TKey">Type of the keys.</typeparam>
/// <typeparam name="TValue">Type of the values.</typeparam>
public sealed class DictionaryUnDo<TKey, TValue> : IUnDo
{
    private readonly object? _description;
    private readonly IDictionary<TKey, TValue> _source;
    private readonly TKey _key;
    [AllowNull]
    private readonly TValue _element;
    private readonly bool _isAdd;

    /// <summary>
    /// Initialise an instance of <see cref="DictionaryUnDo{TKey, TValue}"/>.
    /// </summary>
    /// <param name="description">The description of this <see cref="IUnDo"/></param>
    /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/> on which to perform operation.</param>
    /// <param name="key">The key of the operation.</param>
    /// <param name="value">The value of the operation.</param>
    /// <param name="isAdd">true if the operation is <see cref="IDictionary{TKey, TValue}.Add(TKey, TValue)"/>, false for <see cref="IDictionary{TKey, TValue}.Remove(TKey)"/>.</param>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="key"/> is null.</exception>
    public DictionaryUnDo(object? description, IDictionary<TKey, TValue> source, TKey key, [AllowNull] TValue value, bool isAdd)
    {
        ArgumentNullException.ThrowIfNull(source);
        ArgumentNullException.ThrowIfNull(key);

        _description = description;
        _source = source;
        _key = key;
        _element = value;
        _isAdd = isAdd;
    }

    /// <summary>
    /// Initialise an instance of <see cref="DictionaryUnDo{TKey, TValue}"/>.
    /// </summary>
    /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/> on which to perform operation.</param>
    /// <param name="key">The key of the operation.</param>
    /// <param name="value">The value of the operation.</param>
    /// <param name="isAdd">true if the operation is <see cref="IDictionary{TKey, TValue}.Add(TKey, TValue)"/>, false for <see cref="IDictionary{TKey, TValue}.Remove(TKey)"/>.</param>
    /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="key"/> is null.</exception>
    public DictionaryUnDo(IDictionary<TKey, TValue> source, TKey key, [AllowNull] TValue value, bool isAdd)
        : this(null, source, key, value, isAdd)
    { }

    private void Action(bool isAdd)
    {
        if (isAdd)
        {
            _source.Add(_key, _element);
        }
        else
        {
            _source.Remove(_key);
        }
    }

    #region IUnDo

    /// <inheritdoc />
    object? IUnDo.Description => _description;

    /// <inheritdoc />
    void IUnDo.Do() => Action(_isAdd);

    /// <inheritdoc />
    void IUnDo.Undo() => Action(!_isAdd);

    #endregion
}
