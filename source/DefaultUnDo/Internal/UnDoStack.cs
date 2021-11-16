using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo.Internal
{
    internal sealed class UnDoStack : IUnDoStack
    {
        private readonly Stack<Operation> _doneOperations;
        private readonly Stack<Operation> _undoneOperations;

        public UnDoStack()
        {
            _doneOperations = new Stack<Operation>();
            _undoneOperations = new Stack<Operation>();
        }

        #region IUnDoStack

        public bool CanUndo => _doneOperations.Count > 0;

        public bool CanRedo => _undoneOperations.Count > 0;

        public IEnumerable<object?> UndoDescriptions => _doneOperations.Select(o => o.Command.Description);

        public IEnumerable<object?> RedoDescription => _undoneOperations.Select(o => o.Command.Description);

        public int Push(IUnDo command, int doVersion, int undoVersion)
        {
            if (_doneOperations.Count > 0
                && _doneOperations.Peek().Command is IMergeableUnDo mergeable
                && mergeable.TryMerge(command, out IUnDo? mergedCommand))
            {
                command = mergedCommand;
                undoVersion = _doneOperations.Pop().UndoVersion;
            }

            _doneOperations.Push(new Operation(command, doVersion, undoVersion));
            _undoneOperations.Clear();

            return doVersion;
        }

        public int Undo()
        {
            Operation operation = _doneOperations.Pop();
            _undoneOperations.Push(operation);

            operation.Command.Undo();

            return operation.UndoVersion;
        }

        public int Redo()
        {
            Operation operation = _undoneOperations.Pop();
            _doneOperations.Push(operation);

            operation.Command.Do();

            return operation.DoVersion;
        }

        public void Clear()
        {
            _doneOperations.Clear();
            _undoneOperations.Clear();
        }

        #endregion
    }
}
