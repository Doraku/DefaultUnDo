using System;
using System.Collections.Generic;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides a method to wrap an <see cref="IDictionary{TKey, TValue}"/> to an UnDo dictionary linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
    /// </summary>
    public static class IDictionaryExtension
    {
        #region Types

        internal class UnDoDictionary<TKey, TValue> : ICollectionExtension.UnDoCollection<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>
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

        #endregion

        #region Methods

        /// <summary>
        ///  Wraps an <see cref="IDictionary{TKey, TValue}"/> to an UnDo dictionary linked to an <see cref="IUnDoManager"/> to automatically generate <see cref="IUnDo"/> operations.
        /// </summary>
        /// <typeparam name="TKey">The type of keys.</typeparam>
        /// <typeparam name="TValue">The type of values.</typeparam>
        /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/>.</param>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="descriptionFactory">Factory used to create the description of the generated <see cref="IUnDo"/>, the name of the method called is passed as a parameter.</param>
        /// <returns>A wrapped <see cref="IDictionary{TKey, TValue}"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="manager"/> is null.</exception>
        public static IDictionary<TKey, TValue> AsUnDo<TKey, TValue>(this IDictionary<TKey, TValue> source, IUnDoManager manager, Func<string, string> descriptionFactory = null) => new UnDoDictionary<TKey, TValue>(
            manager ?? throw new ArgumentNullException(nameof(manager)),
            source ?? throw new ArgumentNullException(nameof(source)),
            descriptionFactory);

        #endregion
    }
}
