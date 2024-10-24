using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class RemoveShould
{
    [Fact]
    public void ReturnRemove()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object value = new();

        source.Remove(value).Returns(true);
        source.Contains(value).Returns(true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.Remove(value)).IsEqualTo(source.Remove(value));
    }

    [Fact]
    public void GenerateRemoveDescription()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object item = new();
        unDoCollection.Remove(item);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ICollectionRemove);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(item);
    }
}
