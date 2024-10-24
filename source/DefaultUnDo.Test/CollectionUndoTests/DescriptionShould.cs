using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.CollectionUndoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        IUnDo undo = new CollectionUnDo<object>("test", Substitute.For<ICollection<object>>(), null, true);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
