using System;
using System.Collections.Generic;
using System.ComponentModel;
using DefaultUnDo.Technical;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides an implementation of the command pattern to execute operations and return to a previous state by undoing them.
    /// </summary>
    public sealed class UnDoManager : IUnDoManager
    {
        #region Types

        private sealed class Group : IDisposable
        {
            #region Fields

            private readonly UnDoManager _manager;

            private bool _isDisposed;

            #endregion

            #region Initialisation

            public Group(UnDoManager manager, object description)
            {
                _manager = manager;
                _isDisposed = false;

                if (++_manager._groupCount == 1)
                {
                    manager._groupDescription = description;
                }
            }

            #endregion

            #region IDisposable

            void IDisposable.Dispose()
            {
                if (!_isDisposed)
                {
                    if (--_manager._groupCount == 0 && _manager._groupCommands.Count > 0)
                    {
                        _manager.Push(new GroupUnDo(_manager._groupDescription, _manager._groupCommands.ToArray()));
                        _manager._groupCommands.Clear();
                    }

                    _isDisposed = true;
                    GC.SuppressFinalize(this);
                }
            }

            #endregion
        }

        #endregion

        #region Fields

        private readonly IUnDoStack _stack;
        private readonly List<IUnDo> _groupCommands;
        private int _version;
        private int _lastVersion;
        private int _groupCount;
        private object _groupDescription;

        #endregion

        #region Initialisation

        /// <summary>
        /// Initialises an instance of <see cref="UnDoManager"/>.
        /// </summary>
        /// <param name="maxCapacity">The maximum number of operation this <see cref="UnDoManager"/> can record before errasing oldest ones.</param>
        public UnDoManager(int maxCapacity)
        {
            if (maxCapacity <= 0)
            {
                throw new ArgumentException("maxCapacity must be superior to zero", nameof(maxCapacity));
            }

            _stack = maxCapacity == int.MaxValue ? (IUnDoStack)new UnDoStack() : new UnDoBuffer(maxCapacity);
            _groupCommands = new List<IUnDo>();

            Version = 0;
            _lastVersion = 0;
        }

        /// <summary>
        /// Initialises an instance of <see cref="UnDoManager"/>.
        /// </summary>
        public UnDoManager()
            : this(int.MaxValue)
        { }

        #endregion

        #region Methods

        private void Push(IUnDo command) => Version = _stack.Push(command, ++_lastVersion, Version);

        #endregion

        #region IUnDoManager

        /// <summary>
        /// Gets an <see cref="int"/> representing the state of the <see cref="IUnDoManager"/>.
        /// </summary>
        public int Version
        {
            get => _version;
            private set
            {
                _version = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Version)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanUndo)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanRedo)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UndoDescriptions)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RedoDescriptions)));
            }
        }

        /// <summary>
        /// Returns a boolean to express if the method <see cref="Undo"/> can be executed.
        /// </summary>
        /// <returns>true if <see cref="Undo"/> can be executed, else false.</returns>
        public bool CanUndo => _stack.CanUndo;

        /// <summary>
        /// Returns a boolean to express if the method <see cref="Redo"/> can be executed.
        /// </summary>
        /// <returns>true if <see cref="Redo"/> can be executed, else false.</returns>
        public bool CanRedo => _stack.CanRedo;

        /// <summary>
        /// Gets the descriptions in order of all the <see cref="IUnDo"/> which can be undone.
        /// </summary>
        public IEnumerable<object> UndoDescriptions => _stack.UndoDescriptions;

        /// <summary>
        /// Gets the descriptions in order of all the <see cref="IUnDo"/> which can be redone.
        /// </summary>
        public IEnumerable<object> RedoDescriptions => _stack.RedoDescription;

        /// <summary>
        /// Starts a group of operation and return an <see cref="IDisposable"/> to stop the group.
        /// If multiple calls to this method are made, the group will be stoped once each <see cref="IDisposable"/> returned are disposed.
        /// </summary>
        /// <param name="description">The description of the group operation.</param>
        /// <returns>An <see cref="IDisposable"/> to stop the group operation.</returns>
        public IDisposable BeginGroup(object description = null) => new Group(this, description);

        /// <summary>
        /// Clears the history of <see cref="IUnDo"/> operations.
        /// </summary>
        public void Clear()
        {
            _stack.Clear();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanUndo)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanRedo)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UndoDescriptions)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(RedoDescriptions)));
        }

        /// <summary>
        /// Executes the <see cref="IUnDo"/> command and stores it in the manager hostory.
        /// </summary>
        /// <param name="command">The <see cref="IUnDo"/> to execute.</param>
        /// <exception cref="ArgumentNullException"><paramref name="command"/> is null.</exception>
        public void Do(IUnDo command)
        {
            if (command is null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            command.Do();

            if (_groupCount > 0)
            {
                _groupCommands.Add(command);
            }
            else
            {
                Push(command);
            }
        }

        /// <summary>
        /// Undoes the last executed <see cref="IUnDo"/> command of the manager history.
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot perform <see cref="Undo"/> while a group operation is going on.</exception>
        /// <exception cref="InvalidOperationException">There is no action to undo.</exception>
        public void Undo()
        {
            if (_groupCount > 0)
            {
                throw new InvalidOperationException("Cannot perform Undo while a group operation is going on.");
            }
            if (!CanUndo)
            {
                throw new InvalidOperationException("No operation to undo.");
            }

            Version = _stack.Undo();
        }

        /// <summary>
        /// Redoes the last undone <see cref="IUnDo"/> command of the manager history.
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot perform <see cref="Redo"/> while a group operation is going on.</exception>
        /// <exception cref="InvalidOperationException">There is no action to redo.</exception>
        public void Redo()
        {
            if (_groupCount > 0)
            {
                throw new InvalidOperationException("Cannot perform Redo while a group operation is going on.");
            }
            if (!CanRedo)
            {
                throw new InvalidOperationException("No operation to redo.");
            }

            Version = _stack.Redo();
        }

        #endregion

        #region INotifyPropertyChanged

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
