﻿using System;
using System.Collections.Generic;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for <see cref="ICollection{T}"/> operation.
    /// </summary>
    /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
    public sealed class CollectionUnDo<T> : IUnDo
    {
        #region Fields

        private readonly object _description;
        private readonly ICollection<T> _source;
        private readonly T _item;
        private readonly bool _isAdd;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialise an instance of <see cref="CollectionUnDo{T}"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="source">The <see cref="ICollection{T}"/> on which to perform operation.</param>
        /// <param name="item">The argument of the operation.</param>
        /// <param name="isAdd">true if the operation is an <see cref="ICollection{T}.Add(T)"/>, false for a <see cref="ICollection{T}.Remove(T)"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
        public CollectionUnDo(object description, ICollection<T> source, T item, bool isAdd)
        {
            _description = description;
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _item = item;
            _isAdd = isAdd;
        }

        /// <summary>
        /// Initialise an instance of <see cref="CollectionUnDo{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="ICollection{T}"/> on which to perform operation.</param>
        /// <param name="item">The argument of the operation.</param>
        /// <param name="isAdd">true if the operation is an <see cref="ICollection{T}.Add(T)"/>, false for a <see cref="ICollection{T}.Remove(T)"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
        public CollectionUnDo(ICollection<T> source, T item, bool isAdd)
            : this(null, source, item, isAdd)
        { }

        #endregion

        #region Methods

        private void Action(bool isAdd)
        {
            if (isAdd)
            {
                _source.Add(_item);
            }
            else
            {
                _source.Remove(_item);
            }
        }

        #endregion

        #region IUnDo

        /// <inheritdoc />
        object IUnDo.Description => _description;

        /// <inheritdoc />
        void IUnDo.Undo() => Action(!_isAdd);

        /// <inheritdoc />
        void IUnDo.Do() => Action(_isAdd);

        #endregion
    }
}
