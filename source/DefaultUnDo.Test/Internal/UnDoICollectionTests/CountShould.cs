using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class CountShould
{
    [Fact]
    public void ReturnCount()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        source.Count.Returns(1337);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.Count).IsEqualTo(source.Count);
    }
}
