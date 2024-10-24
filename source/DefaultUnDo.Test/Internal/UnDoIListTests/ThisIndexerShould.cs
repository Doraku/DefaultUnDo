using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIListTests;

public sealed class ThisIndexerShould
{
    [Fact]
    public void ReturnThisIndexGet()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        const int index = 42;
        object value = new();

        source[index].Returns(value);

        IList<object> unDoList = source.AsUnDo(manager);

        Check.That(unDoList[index]).IsEqualTo(source[index]);
    }

    [Fact]
    public void SetThisIndex()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        const int index = 42;
        object value = new();

        bool done = false;

        source.When(s => s[index] = value).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoList = source.AsUnDo(manager);

        unDoList[index] = value;

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateThisDescription()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        const int index = 42;
        object item = new();
        unDoCollection[index] = item;

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListIndexer);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(index);
        Check.That(description.Value.Parameters[1]).IsEqualTo(item);
    }
}
