using System;
using System.Linq;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for a group of operations.
    /// </summary>
    public sealed class GroupUnDo : IUnDo
    {
        #region Fields

        private readonly string _description;
        private readonly IUnDo[] _commands;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialise an instance of <see cref="GroupUnDo"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="commands">The sequence of <see cref="IUnDo"/> contained by the instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="commands"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="commands"/> contains null elements.</exception>
        public GroupUnDo(string description, params IUnDo[] commands)
        {
            _description = description ?? string.Empty;
            _commands = commands ?? throw new ArgumentNullException(nameof(commands));

            if (_commands.Any(i => i is null))
            {
                throw new ArgumentException("IUnDo sequence contains null elements.", nameof(commands));
            }
        }

        /// <summary>
        /// Initialise an instance of <see cref="GroupUnDo"/>.
        /// </summary>
        /// <param name="commands">The sequence of <see cref="IUnDo"/> contained by the instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="commands"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="commands"/> contains null elements.</exception>
        public GroupUnDo(params IUnDo[] commands)
            : this(null, commands)
        { }

        #endregion

        #region IUnDo

        string IUnDo.Description => _description;

        void IUnDo.Do()
        {
            foreach (IUnDo command in _commands)
            {
                command.Do();
            }
        }

        void IUnDo.Undo()
        {
            for (int i = _commands.Length - 1; i >= 0; --i)
            {
                _commands[i].Undo();
            }
        }

        #endregion
    }
}
