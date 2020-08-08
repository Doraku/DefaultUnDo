using System;
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

        private readonly ICollection<T> _source;
        private readonly T _element;
        private readonly bool _isAdd;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialise an instance of <see cref="CollectionUnDo{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="ICollection{T}"/> on which to perform operation.</param>
        /// <param name="element">The argument of the operation.</param>
        /// <param name="isAdd">true if the operation is an <see cref="ICollection{T}.Add(T)"/>, false for a <see cref="ICollection{T}.Remove(T)"/>.</param>
        public CollectionUnDo(ICollection<T> source, T element, bool isAdd)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _element = element;
            _isAdd = isAdd;
        }

        #endregion

        #region Methods

        private void Action(bool isAdd)
        {
            if (isAdd)
            {
                _source.Add(_element);
            }
            else
            {
                _source.Remove(_element);
            }
        }

        #endregion

        #region IUnDo

        void IUnDo.Undo() => Action(!_isAdd);

        void IUnDo.Do() => Action(_isAdd);

        #endregion
    }
}
