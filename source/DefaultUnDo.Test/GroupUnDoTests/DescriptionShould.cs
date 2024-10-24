using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.GroupUnDoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        IUnDo undo = new GroupUnDo("test", Substitute.For<IUnDo>());

        Check.That(undo.Description).IsEqualTo("test");
    }
}
