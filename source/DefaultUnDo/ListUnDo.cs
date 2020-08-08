using System;
using System.Collections.Generic;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for <see cref="IList{T}"/> operation.
    /// </summary>
    /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
    public sealed class ListUnDo<T> : IUnDo
    {
        #region Fields

        private readonly IList<T> _source;
        private readonly int _index;
        private readonly T _element;
        private readonly bool _isAdd;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="ListUnDo{T}"/>.
        /// </summary>
        /// <param name="source">The <see cref="IList{T}"/> on which the operation is performed.</param>
        /// <param name="index">The index of the operation.</param>
        /// <param name="element">The argument of the operation.</param>
        /// <param name="isAdd">true if the operation is an <see cref="IList{T}.IndexOf(T)"/>, else false for a <see cref="IList{T}.RemoveAt(int)"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="source"/> is null.</exception>
        public ListUnDo(IList<T> source, int index, T element, bool isAdd)
        {
            _source = source ?? throw new ArgumentNullException(nameof(source));
            _index = index;
            _element = element;
            _isAdd = isAdd;
        }

        #endregion

        #region Methods

        private void Action(bool isAdd)
        {
            if (isAdd)
            {
                _source.Insert(_index, _element);
            }
            else
            {
                _source.RemoveAt(_index);
            }
        }

        #endregion

        #region IUnDo

        void IUnDo.Do() => Action(_isAdd);

        void IUnDo.Undo() => Action(!_isAdd);

        #endregion
    }
}
