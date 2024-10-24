using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class IsReadOnlyShould
{
    [Fact]
    public void ReturnIsReadOnly()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        source.IsReadOnly.Returns(true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.IsReadOnly).IsEqualTo(source.IsReadOnly);
    }
}
