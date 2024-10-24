using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class GetEnumeratorTShould
{
    [Fact]
    public void ReturnGetEnumeratorT()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator<object> enumerator = Substitute.For<IEnumerator<object>>();

        source.GetEnumerator().Returns(enumerator);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.GetEnumerator()).IsEqualTo(source.GetEnumerator());
    }
}
