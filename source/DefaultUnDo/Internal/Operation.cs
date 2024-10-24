namespace DefaultUnDo.Internal;

internal readonly record struct Operation(
    IUnDo Command,
    int DoVersion,
    int UndoVersion);