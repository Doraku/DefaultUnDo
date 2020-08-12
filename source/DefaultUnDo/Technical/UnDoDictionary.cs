﻿using System;
using System.Collections.Generic;

namespace DefaultUnDo.Technical
{
    internal class UnDoDictionary<TKey, TValue> : UnDoCollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>
    {
        #region Fields

        private readonly IDictionary<TKey, TValue> _source;

        #endregion

        #region Initialisation

        public UnDoDictionary(IUnDoManager manager, IDictionary<TKey, TValue> source, Func<string, string> descriptionFactory)
            : base(manager, source, descriptionFactory)
        {
            _source = source;
        }

        #endregion

        #region IDictionary

        void IDictionary<TKey, TValue>.Add(TKey key, TValue value) => _manager.DoAdd(_source, key, value, _descriptionFactory?.Invoke(nameof(IDictionary<TKey, TValue>.Add)));

        bool IDictionary<TKey, TValue>.ContainsKey(TKey key) => _source.ContainsKey(key);

        bool IDictionary<TKey, TValue>.Remove(TKey key) => _manager.DoRemove(_source, key, _descriptionFactory?.Invoke(nameof(IDictionary<TKey, TValue>.Remove)));

        bool IDictionary<TKey, TValue>.TryGetValue(TKey key, out TValue value) => _source.TryGetValue(key, out value);

        TValue IDictionary<TKey, TValue>.this[TKey key]
        {
            get => _source[key];
            set => _manager.Do(_source, key, value, _descriptionFactory?.Invoke("this"));
        }

        ICollection<TKey> IDictionary<TKey, TValue>.Keys => _source.Keys;

        ICollection<TValue> IDictionary<TKey, TValue>.Values => _source.Values;

        #endregion
    }
}
