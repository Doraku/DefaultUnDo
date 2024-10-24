using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class ContainsShould
{
    [Fact]
    public void ReturnContains()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object value = new();

        source.Contains(value).Returns(true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.Contains(value)).IsEqualTo(source.Contains(value));
    }
}
