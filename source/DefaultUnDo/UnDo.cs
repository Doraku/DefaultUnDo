using System;

namespace DefaultUnDo;

/// <summary>
/// Provides an implementation of the <see cref="IUnDo"/> interface for custom do and undo action.
/// </summary>
public sealed class UnDo : IUnDo
{
    private readonly object? _description;
    private readonly Action? _doAction;
    private readonly Action? _undoAction;

    /// <summary>
    /// Initialises an instance of <see cref="UnDo"/>.
    /// </summary>
    /// <param name="description">The description of this <see cref="IUnDo"/></param>
    /// <param name="doAction">The action called by <see cref="IUnDo.Do"/>.</param>
    /// <param name="undoAction">The action called by <see cref="IUnDo.Undo"/>.</param>
    public UnDo(object? description, Action? doAction, Action? undoAction)
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
    public UnDo(Action? doAction, Action? undoAction)
        : this(null, doAction, undoAction)
    { }

    #region IUnDo

    /// <inheritdoc />
    object? IUnDo.Description => _description;

    /// <inheritdoc />
    void IUnDo.Do() => _doAction?.Invoke();

    /// <inheritdoc />
    void IUnDo.Undo() => _undoAction?.Invoke();

    #endregion
}
