using System.Collections.Generic;

namespace DefaultUnDo.Technical
{
    internal sealed class UnDoBuffer : IUnDoStack
    {
        private readonly Operation[] _buffer;

        private bool _hasOperation;
        private bool? _currentState;
        private int _current;
        private int _head;
        private int _tail;

        public UnDoBuffer(int maxCapacity)
        {
            _buffer = new Operation[maxCapacity];

            Clear();
        }

        #region IUnDoStack

        public bool CanUndo => _hasOperation && (_current != _tail || _currentState != false);

        public bool CanRedo => _hasOperation && (_current != _head || _currentState != true);

        public IEnumerable<string> UndoDescriptions
        {
            get
            {
                if (_hasOperation)
                {
                    for (int i = _current; ; --i)
                    {
                        if (i < 0)
                        {
                            i += _buffer.Length;
                        }
                        if (i == _tail)
                        {
                            if (_currentState is true)
                            {
                                yield return _buffer[i].Command.Description;
                            }

                            break;
                        }

                        yield return _buffer[i].Command.Description;
                    }
                }
            }
        }
        public IEnumerable<string> RedoDescription
        {
            get
            {
                if (_hasOperation)
                {
                    for (int i = _current; ; ++i)
                    {
                        if (i == _buffer.Length)
                        {
                            i = 0;
                        }
                        if (i == _head)
                        {
                            if (_currentState is false)
                            {
                                yield return _buffer[i].Command.Description;
                            }

                            break;
                        }

                        yield return _buffer[i].Command.Description;
                    }
                }
            }
        }

        public void Clear()
        {
            _hasOperation = false;
            _currentState = null;
            _current = 0;
            _head = 0;
            _tail = 0;
        }

        public int Push(IUnDo command, int doVersion, int undoVersion)
        {
            if (_hasOperation)
            {
                if (_buffer[_current].Command is IMergeableUnDo mergeable
                    && mergeable.TryMerge(command, out IUnDo mergedCommand))
                {
                    command = mergedCommand;
                    undoVersion = _buffer[_current].UndoVersion;
                }
                else
                {
                    if (++_current >= _buffer.Length)
                    {
                        _current -= _buffer.Length;
                    }

                    if (_tail == _current && ++_tail >= _buffer.Length)
                    {
                        _tail -= _buffer.Length;
                    }
                }
            }

            _hasOperation = true;
            _currentState = true;
            _buffer[_current] = new Operation(command, doVersion, undoVersion);
            _head = _current;

            return doVersion;
        }

        public int Undo()
        {
            Operation operation = _buffer[_current];

            if (_current != _tail)
            {
                _currentState = null;
                if (--_current < 0)
                {
                    _current += _buffer.Length;
                }
            }
            else
            {
                _currentState = false;
            }

            operation.Command.Undo();

            return operation.UndoVersion;
        }

        public int Redo()
        {
            Operation operation = _buffer[_current];

            if (_current != _head)
            {
                _currentState = null;
                if (++_current >= _buffer.Length)
                {
                    _current -= _buffer.Length;
                }
            }
            else
            {
                _currentState = true;
            }

            operation.Command.Do();

            return operation.DoVersion;
        }

        #endregion
    }
}
