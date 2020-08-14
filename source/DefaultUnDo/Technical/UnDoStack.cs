using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo.Technical
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

        public IEnumerable<string> UndoDescriptions => _doneOperations.Select(o => o.Command.Description);

        public IEnumerable<string> RedoDescription => _undoneOperations.Select(o => o.Command.Description);

        public int Push(IUnDo command, int doVersion, int undoVersion)
        {
            if (_doneOperations.Count > 0
                && _doneOperations.Peek().Command is IMergeableUnDo mergeable
                && mergeable.TryMerge(command, out IUnDo mergedCommand))
            {
                _doneOperations.Push(new Operation(mergedCommand, doVersion, _doneOperations.Pop().UndoVersion));
            }
            else
            {
                _doneOperations.Push(new Operation(command, doVersion, undoVersion));
            }

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
