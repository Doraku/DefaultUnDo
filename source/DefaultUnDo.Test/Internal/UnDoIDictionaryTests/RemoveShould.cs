using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class RemoveShould
{
    [Fact]
    public void ReturnRemoveKey()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        source.Remove(key).Returns(true);
        source.TryGetValue(key, out value).ReturnsForAnyArgs(true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary.Remove(key)).IsEqualTo(source.Remove(key));
    }

    [Fact]
    public void GenerateRemoveDescription()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object key = new();
        unDoCollection.Remove(key);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryRemove);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(key);
    }
}
