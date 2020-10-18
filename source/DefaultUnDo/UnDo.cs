using System;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for custom do and undo action.
    /// </summary>
    public sealed class UnDo : IUnDo
    {
        #region Fields

        private readonly object _description;
        private readonly Action _doAction;
        private readonly Action _undoAction;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="UnDo"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="doAction">The action called by <see cref="IUnDo.Do"/>.</param>
        /// <param name="undoAction">The action called by <see cref="IUnDo.Undo"/>.</param>
        public UnDo(object description, Action doAction, Action undoAction)
        {
            _description = description;
            _doAction = doAction;
            _undoAction = undoAction;
        }

        /// <summary>
        /// Initialises an instance of <see cref="UnDo"/>.
        /// </summary>
        /// <param name="doAction">The action called by <see cref="IUnDo.Do"/>.</param>
        /// <param name="undoAction">The action called by <see cref="IUnDo.Undo"/>.</param>
        public UnDo(Action doAction, Action undoAction)
            : this(null, doAction, undoAction)
        { }

        #endregion

        #region IUnDo

        object IUnDo.Description => _description;

        void IUnDo.Do() => _doAction?.Invoke();

        void IUnDo.Undo() => _undoAction?.Invoke();

        #endregion
    }
}
