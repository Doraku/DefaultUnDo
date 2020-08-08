using System;
using System.ComponentModel;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides properties and methods of the command pattern to execute operations and return to a previous state by undoing them.
    /// </summary>
    public interface IUnDoManager : INotifyPropertyChanged
    {
        /// <summary>
        /// Gets an <see cref="int"/> representing the state of the <see cref="IUnDoManager"/>.
        /// </summary>
        int Version { get; }

        /// <summary>
        /// Returns a boolean to express if the method <see cref="Undo"/> can be executed.
        /// </summary>
        /// <returns>true if <see cref="Undo"/> can be executed, else false.</returns>
        bool CanUndo { get; }

        /// <summary>
        /// Returns a boolean to express if the method <see cref="Redo"/> can be executed.
        /// </summary>
        /// <returns>true if <see cref="Redo"/> can be executed, else false.</returns>
        bool CanRedo { get; }

        /// <summary>
        /// Starts a group of operation and return an <see cref="IDisposable"/> to stop the group.
        /// If multiple calls to this method are made, the group will be stoped once each <see cref="IDisposable"/> returned are disposed.
        /// </summary>
        /// <returns>An <see cref="IDisposable"/> to stop the group operation.</returns>
        IDisposable BeginGroup();

        /// <summary>
        /// Clears the history of <see cref="IUnDo"/> operations.
        /// </summary>
        void Clear();

        /// <summary>
        /// Executes the <see cref="IUnDo"/> command and stores it in the manager hostory.
        /// </summary>
        /// <param name="command">The <see cref="IUnDo"/> to execute.</param>
        /// <exception cref="ArgumentNullException"><paramref name="command"/> is null.</exception>
        void Do(IUnDo command);

        /// <summary>
        /// Redoes the last undone <see cref="IUnDo"/> command of the manager history.
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot perform <see cref="Redo"/> while a group operation is going on.</exception>
        /// <exception cref="InvalidOperationException">There is no action to redo.</exception>
        void Redo();

        /// <summary>
        /// Undoes the last executed <see cref="IUnDo"/> command of the manager history.
        /// </summary>
        /// <exception cref="InvalidOperationException">Cannot perform <see cref="Undo"/> while a group operation is going on.</exception>
        /// <exception cref="InvalidOperationException">There is no action to undo.</exception>
        void Undo();
    }
}