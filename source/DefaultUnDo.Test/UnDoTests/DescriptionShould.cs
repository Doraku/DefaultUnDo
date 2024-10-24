using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        IUnDo undo = new UnDo("test", null, null);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
