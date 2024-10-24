using NFluent;
using Xunit;

namespace DefaultUnDo.ValueUnDoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        IUnDo undo = new ValueUnDo<object>("test", _ => { }, null, null);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
