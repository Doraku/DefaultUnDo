using System;

namespace DefaultUnDo;

/// <summary>
/// Represents a transaction to record multiple undo operations as a single operation in the history of a <see cref="IUnDoManager"/>.
/// </summary>
public interface IUnDoTransaction : IDisposable
{
    /// <summary>
    /// Groups all recorded operations in a single <see cref="GroupUnDo"/> and add it to the history of the <see cref="IUnDoManager"/> instance this instance was created from.
    /// If this method is not called before disposing current instance, all recorded operations will be undone.
    /// </summary>
    /// <exception cref="ObjectDisposedException"></exception>
    /// <exception cref="InvalidOperationException">Current transaction has already been committed</exception>
    /// <exception cref="InvalidOperationException">Current transaction is not the highest one on the stack</exception>
    void Commit();
}
