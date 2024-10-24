using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class AddShould
{
    [Fact]
    public void Add()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object value = new();

        bool done = false;

        source.When(s => s.Add(value)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        unDoCollection.Add(value);

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateAddDescription()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object item = new();
        unDoCollection.Add(item);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ICollectionAdd);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(item);
    }
}
