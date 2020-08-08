﻿using System;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for custom do and undo action.
    /// </summary>
    public sealed class UnDo : IUnDo
    {
        #region Fields

        private readonly Action _doAction;
        private readonly Action _undoAction;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="UnDo"/>.
        /// </summary>
        /// <param name="doAction">The action called by <see cref="IUnDo.Do"/>.</param>
        /// <param name="undoAction">The action called by <see cref="IUnDo.Undo"/>.</param>
        public UnDo(Action doAction, Action undoAction)
        {
            _doAction = doAction;
            _undoAction = undoAction;
        }

        #endregion

        #region IUnDo

        void IUnDo.Do() => _doAction?.Invoke();

        void IUnDo.Undo() => _undoAction?.Invoke();

        #endregion
    }
}
