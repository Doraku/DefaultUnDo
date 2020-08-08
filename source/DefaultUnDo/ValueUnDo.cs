using System;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for setting value.
    /// </summary>
    /// <typeparam name="T">The type of value.</typeparam>
    public sealed class ValueUnDo<T> : IUnDo
    {
        #region Fields

        private readonly Action<T> _setter;
        private readonly T _newValue;
        private readonly T _oldValue;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="ValueUnDo{T}"/>.
        /// </summary>
        /// <param name="setter">The action called to set the value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="oldValue">The old value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="setter"/> is null.</exception>
        public ValueUnDo(Action<T> setter, T newValue, T oldValue)
        {
            _setter = setter ?? throw new ArgumentNullException(nameof(setter));
            _newValue = newValue;
            _oldValue = oldValue;
        }

        #endregion

        #region IUnDo

        void IUnDo.Do() => _setter.Invoke(_newValue);

        void IUnDo.Undo() => _setter.Invoke(_oldValue);

        #endregion
    }
}
