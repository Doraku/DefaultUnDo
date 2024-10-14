namespace DefaultUnDo;

/// <summary>
/// Provides methods to execute an action and remove its effect.
/// </summary>
public interface IUnDo
{
    /// <summary>
    /// Gets a description of what this <see cref="IUnDo"/> perform.
    /// </summary>
    object? Description { get; }

    /// <summary>
    /// Does an action.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "we do")]
    void Do();

    /// <summary>
    /// Does the opposite of the <see cref="Do"/> action.
    /// </summary>
    void Undo();
}
