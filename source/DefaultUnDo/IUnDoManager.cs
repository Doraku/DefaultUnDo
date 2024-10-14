using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DefaultUnDo;

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
    /// Gets the descriptions in order of all the <see cref="IUnDo"/> which can be undone.
    /// </summary>
    IEnumerable<object?> UndoDescriptions { get; }

    /// <summary>
    /// Gets the descriptions in order of all the <see cref="IUnDo"/> which can be redone.
    /// </summary>
    IEnumerable<object?> RedoDescriptions { get; }

    /// <summary>
    /// Starts a group of operation and return an <see cref="IUnDoTransaction"/> to stop the group.
    /// If <see cref="IUnDoTransaction.Commit"/> is not called, all operations done during the transaction will be undone on <see cref="IDisposable.Dispose"/>.
    /// </summary>
    /// <param name="description">The description of the group of operations.</param>
    /// <returns>An <see cref="IUnDoTransaction"/> to commit or rollback the transaction of operations.</returns>
    IUnDoTransaction BeginTransaction(object? description = null);

    /// <summary>
    /// Clears the history of <see cref="IUnDo"/> operations.
    /// </summary>
    void Clear();

    /// <summary>
    /// Executes the <see cref="IUnDo"/> command and stores it in the manager hostory.
    /// </summary>
    /// <param name="command">The <see cref="IUnDo"/> to execute.</param>
    /// <exception cref="ArgumentNullException"><paramref name="command"/> is null.</exception>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "we do")]
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