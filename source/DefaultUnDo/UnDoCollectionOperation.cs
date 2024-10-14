namespace DefaultUnDo;

/// <summary>
/// Provides data for the operation about to be performed on an undo collection.
/// </summary>
/// <param name="Collection">The collection on which the action is performed.</param>
/// <param name="Action">The action performed.</param>
/// <param name="Parameters">The parameters of the action performed.</param>
public readonly record struct UnDoCollectionOperation(
    object Collection,
    UnDoCollectionAction Action,
    params object?[] Parameters);
