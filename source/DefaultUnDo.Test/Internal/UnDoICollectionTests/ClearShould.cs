using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class ClearShould
{
    [Fact]
    public void Clear()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        bool done = false;

        source.Count.Returns(42);
        source.When(s => s.Clear()).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        unDoCollection.Clear();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateClearDescription()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        unDoCollection.Clear();

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ICollectionClear);
        Check.That(description.Value.Parameters.Length).IsZero();
    }
}
