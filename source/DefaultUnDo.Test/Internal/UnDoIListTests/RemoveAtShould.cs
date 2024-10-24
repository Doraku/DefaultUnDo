using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIListTests;

public sealed class RemoveAtShould
{
    [Fact]
    public void RemoveAt()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        const int index = 42;

        bool done = false;

        source.When(s => s.RemoveAt(index)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoList = source.AsUnDo(manager);

        unDoList.RemoveAt(index);

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateRemoveAtDescription()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        const int index = 42;
        unDoCollection.RemoveAt(index);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListRemoveAt);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(index);
    }
}
