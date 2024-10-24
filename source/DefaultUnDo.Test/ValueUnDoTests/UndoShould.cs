using NFluent;
using Xunit;

namespace DefaultUnDo.ValueUnDoTests;

public sealed class UndoShould
{
    [Fact]
    public void SetOldValue()
    {
        object value = null;
        object oldValue = new();
        object newValue = new();
        IUnDo undo = new ValueUnDo<object>(v => value = v, newValue, oldValue);

        undo.Undo();

        Check.That(value).IsEqualTo(oldValue);
    }
}
