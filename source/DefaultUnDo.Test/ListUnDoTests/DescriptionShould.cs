using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.ListUnDoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        IUnDo undo = new ListUnDo<object>("test", Substitute.For<IList<object>>(), 0, null, true);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
