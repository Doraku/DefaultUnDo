using System;
using System.Linq;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for a group of operations.
    /// </summary>
    public sealed class GroupUnDo : IMergeableUnDo
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

            if (_commands.Length is 0)
            {
                throw new ArgumentException("IUnDo sequence contains no elements.", nameof(commands));
            }
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

        #region Method

        /// <summary>
        /// Gets the single <typeparamref name="T"/> of this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command">When this method returns, the single <typeparamref name="T"/> of this instance, if it was its only command; otherwise, the default value for the type <typeparamref name="T"/>.
        /// This parameter is passed uninitialized.</param>
        /// <returns>true if the current instance contains exactly one <typeparamref name="T"/>; otherwise false.</returns>
        public bool TryGetSingle<T>(out T command)
            where T : IUnDo
        {
            command = _commands.Length is 1 && _commands[0] is T t ? t : default;

            return command != null;
        }

        #endregion

        #region IMergeableUnDo

        bool IMergeableUnDo.TryMerge(IUnDo other, out IUnDo mergedCommand)
        {
            mergedCommand =
                _description == other.Description
                    && TryGetSingle(out IMergeableUnDo mergeable)
                    && mergeable.TryMerge(other, out mergedCommand)
                ? new GroupUnDo(_description, mergedCommand)
                : null;

            return mergedCommand != null;
        }

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
