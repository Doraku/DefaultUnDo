using System.Collections;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class GetEnumeratorShould
{
    [Fact]
    public void ReturnGetEnumerator()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();

        ((IEnumerable)source).GetEnumerator().Returns(enumerator);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(((IEnumerable)unDoCollection).GetEnumerator()).IsEqualTo(((IEnumerable)source).GetEnumerator());
    }
}
