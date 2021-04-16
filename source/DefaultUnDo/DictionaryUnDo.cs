using System;
using System.Collections.Generic;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for <see cref="IDictionary{TKey, TValue}"/> operation.
    /// </summary>
    /// <typeparam name="TKey">Type of the keys.</typeparam>
    /// <typeparam name="TValue">Type of the values.</typeparam>
    public sealed class DictionaryUnDo<TKey, TValue> : IUnDo
    {
        #region Fields

        private readonly object _description;
        private readonly IDictionary<TKey, TValue> _source;
        private readonly TKey _key;
        private readonly TValue _element;
        private readonly bool _isAdd;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialise an instance of <see cref="DictionaryUnDo{TKey, TValue}"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/> on which to perform operation.</param>
        /// <param name="key">The key of the operation.</param>
        /// <param name="value">The value of the operation.</param>
        /// <param name="isAdd">true if the operation is <see cref="IDictionary{TKey, TValue}.Add(TKey, TValue)"/>, false for <see cref="IDictionary{TKey, TValue}.Remove(TKey)"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> or <paramref name="key"/> is null.</exception>
        public DictionaryUnDo(object description, IDictionary<TKey, TValue> source, TKey key, TValue value, bool isAdd)
        {
            _description = description;
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _key = key ?? throw new ArgumentNullException(nameof(key));
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
        public DictionaryUnDo(IDictionary<TKey, TValue> source, TKey key, TValue value, bool isAdd)
            : this(null, source, key, value, isAdd)
        { }

        #endregion

        #region Methods

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

        #endregion

        #region IUnDo

        /// <inheritdoc />
        object IUnDo.Description => _description;

        /// <inheritdoc />
        void IUnDo.Do() => Action(_isAdd);

        /// <inheritdoc />
        void IUnDo.Undo() => Action(!_isAdd);

        #endregion
    }
}
