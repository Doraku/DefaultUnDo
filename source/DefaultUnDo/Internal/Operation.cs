namespace DefaultUnDo.Internal
{
    internal readonly struct Operation
    {
        public readonly IUnDo Command;
        public readonly int DoVersion;
        public readonly int UndoVersion;

        public Operation(IUnDo command, int doVersion, int undoVersion)
        {
            Command = command;
            DoVersion = doVersion;
            UndoVersion = undoVersion;
        }
    }
}
