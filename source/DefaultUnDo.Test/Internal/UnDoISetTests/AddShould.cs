using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoISetTests;

public sealed class AddShould
{
    [Fact]
    public void ReturnTrueWhenAdded()
    {
        ISet<int> source = Substitute.For<ISet<int>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ISet<int> unDoSet = source.AsUnDo(manager);
        bool done = false;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));
        source.When(s => ((ICollection<int>)s).Add(42)).Do(_ => done = true);

        source.Contains(42).Returns(false);
        Check.That(unDoSet.Add(42)).IsTrue();
        Check.That(done).IsTrue();

        done = false;
        source.Contains(42).Returns(true);
        Check.That(unDoSet.Add(42)).IsFalse();
        Check.That(done).IsFalse();
    }

    [Fact]
    public void GenerateAddDescription()
    {
        ISet<object> source = Substitute.For<ISet<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ISet<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object item = new();
        unDoCollection.Add(item);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ISetAdd);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(item);
    }
}
