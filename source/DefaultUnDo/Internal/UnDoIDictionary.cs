﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DefaultUnDo.Internal;

internal sealed class UnDoIDictionary<TKey, TValue> : UnDoICollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>
{
    private readonly IDictionary<TKey, TValue> _source;

    public UnDoIDictionary(IUnDoManager manager, IDictionary<TKey, TValue> source, Func<UnDoCollectionOperation, object?>? descriptionFactory)
        : base(manager, source, descriptionFactory)
    {
        _source = source;
    }

    #region IDictionary

    void IDictionary<TKey, TValue>.Add(TKey key, TValue value) => _manager.DoAdd(_source, key, value, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.IDictionaryAdd, key, value)));

    bool IDictionary<TKey, TValue>.ContainsKey(TKey key) => _source.ContainsKey(key);

    bool IDictionary<TKey, TValue>.Remove(TKey key) => _manager.DoRemove(_source, key, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.IDictionaryRemove, key)));

    bool IDictionary<TKey, TValue>.TryGetValue(
        TKey key,
#if NET5_0_OR_GREATER
        [MaybeNullWhen(false)]
#endif
        out TValue value)
        => _source.TryGetValue(key, out value);

    TValue IDictionary<TKey, TValue>.this[TKey key]
    {
        get => _source[key];
        set => _manager.Do(_source, key, value, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.IDictionaryIndexer, key, value)));
    }

    ICollection<TKey> IDictionary<TKey, TValue>.Keys => _source.Keys;

    ICollection<TValue> IDictionary<TKey, TValue>.Values => _source.Values;

    #endregion
}
