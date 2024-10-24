using NFluent;
using Xunit;

namespace DefaultUnDo.ValueUnDoTests;

public sealed class DoShould
{
    [Fact]
    public void SetNewValue()
    {
        object value = null;
        object oldValue = new();
        object newValue = new();
        IUnDo undo = new ValueUnDo<object>(v => value = v, newValue, oldValue);

        undo.Do();

        Check.That(value).IsEqualTo(newValue);
    }
}
