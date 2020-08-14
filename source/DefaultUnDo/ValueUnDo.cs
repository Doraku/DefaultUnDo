using System;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for setting value.
    /// </summary>
    /// <typeparam name="T">The type of value.</typeparam>
    public sealed class ValueUnDo<T> : IMergeableUnDo
    {
        #region Fields

        private readonly DateTime _timeStamp;
        private readonly string _description;
        private readonly Action<T> _setter;
        private readonly T _newValue;
        private readonly T _oldValue;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="ValueUnDo{T}"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="setter">The action called to set the value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="oldValue">The old value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="setter"/> is null.</exception>
        public ValueUnDo(string description, Action<T> setter, T newValue, T oldValue)
        {
            _timeStamp = DateTime.Now;
            _description = description ?? string.Empty;
            _setter = setter ?? throw new ArgumentNullException(nameof(setter));
            _newValue = newValue;
            _oldValue = oldValue;
        }

        /// <summary>
        /// Initialises an instance of <see cref="ValueUnDo{T}"/>.
        /// </summary>
        /// <param name="setter">The action called to set the value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="oldValue">The old value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="setter"/> is null.</exception>
        public ValueUnDo(Action<T> setter, T newValue, T oldValue)
            : this(null, setter, newValue, oldValue)
        { }

        #endregion

        #region IMergeableUnDo

        bool IMergeableUnDo.TryMerge(IUnDo command, out IUnDo mergedCommand)
        {
            if (command is GroupUnDo group
                && !group.IsSingle(out command))
            {
                mergedCommand = null;
                return false;
            }

            if (command is ValueUnDo<T> value
                && _description == value._description
                && _setter == value._setter
                && Equals(_newValue, value._oldValue)
                && (value._timeStamp - _timeStamp) < TimeSpan.FromMilliseconds(500))
            {
                mergedCommand = new ValueUnDo<T>(_description, _setter, value._newValue, _oldValue);
                return true;
            }

            mergedCommand = default;
            return false;
        }

        #endregion

        #region IUnDo

        string IUnDo.Description => _description;

        void IUnDo.Do() => _setter.Invoke(_newValue);

        void IUnDo.Undo() => _setter.Invoke(_oldValue);

        #endregion
    }
}
