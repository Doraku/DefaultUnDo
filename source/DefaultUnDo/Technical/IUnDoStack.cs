using System.Collections.Generic;

namespace DefaultUnDo.Technical
{
    internal interface IUnDoStack
    {
        bool CanUndo { get; }

        bool CanRedo { get; }

        IEnumerable<string> UndoDescriptions { get; }

        IEnumerable<string> RedoDescription { get; }

        int Push(IUnDo command, int doVersion, int undoVersion);

        int Undo();

        int Redo();

        void Clear();
    }
}
