using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class CopyToShould
{
    [Fact]
    public void CopyTo()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object[] values = [];
        const int index = 42;

        bool done = false;

        source.When(s => s.CopyTo(values, index)).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        unDoCollection.CopyTo(values, index);

        Check.That(done).IsTrue();
    }
}
