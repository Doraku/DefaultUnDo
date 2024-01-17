using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the <see cref="IUnDo"/> interface for a group of operations.
    /// </summary>
    public sealed class GroupUnDo : IMergeableUnDo
    {
        /// <summary>
        /// Represents a method that will be called when merging a <see cref="GroupUnDo"/> and a <see cref="IMergeableUnDo"/> instances to get the resulting description.
        /// </summary>
        /// <param name="oldDescription">The description of the previous <see cref="GroupUnDo"/> merged.</param>
        /// <param name="newDescription">The description of the new <see cref="IMergeableUnDo"/> merged.</param>
        /// <param name="mergedDescription">The description of the new resulting <see cref="IMergeableUnDo"/> merged.</param>
        /// <returns>The final description to use.</returns>
        public delegate object MergeDescriptionHandler(object? oldDescription, object? newDescription, object? mergedDescription);

        private readonly object? _description;
        private readonly IUnDo[] _commands;

        /// <summary>
        /// The <see cref="MergeDescriptionHandler"/> used to merge description between a <see cref="GroupUnDo"/> and a <see cref="IMergeableUnDo"/> instances.
        /// </summary>
        public static MergeDescriptionHandler? MergeDescriptionAction { get; set; }

        /// <summary>
        /// Initialise an instance of <see cref="GroupUnDo"/>.
        /// </summary>
        /// <param name="description">The description of this <see cref="IUnDo"/></param>
        /// <param name="commands">The sequence of <see cref="IUnDo"/> contained by the instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="commands"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="commands"/> contains null elements.</exception>
        public GroupUnDo(object? description, params IUnDo[] commands)
        {
            ArgumentNullException.ThrowIfNull(commands);

            _description = description;
            _commands = commands;

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

        /// <summary>
        /// Gets the single <typeparamref name="T"/> of this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="command">
        /// When this method returns, the single <typeparamref name="T"/> of this instance, if it was its only command; otherwise, the default value for the type <typeparamref name="T"/>.
        /// This parameter is passed uninitialized.
        /// </param>
        /// <returns>true if the current instance contains exactly one <typeparamref name="T"/>; otherwise false.</returns>
        public bool TryGetSingle<T>([NotNullWhen(true)] out T command)
            where T : IUnDo
        {
            command = _commands.Length is 1 && _commands[0] is T t ? t : default!;

            return command != null;
        }

        #region IMergeableUnDo

        /// <inheritdoc />
        bool IMergeableUnDo.TryMerge(IUnDo other, [NotNullWhen(true)] out IUnDo? mergedCommand)
        {
            mergedCommand =
                TryGetSingle(out IMergeableUnDo mergeable) && mergeable.TryMerge(other, out mergedCommand)
                ? new GroupUnDo(
                    MergeDescriptionAction?.Invoke(_description, mergeable.Description, mergedCommand!.Description) ?? _description,
                    mergedCommand)
                : null;

            return mergedCommand != null;
        }

        #endregion

        #region IUnDo

        /// <inheritdoc />
        object? IUnDo.Description => _description;

        /// <inheritdoc />
        void IUnDo.Do()
        {
            foreach (IUnDo command in _commands)
            {
                command.Do();
            }
        }

        /// <inheritdoc />
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
