using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class AddShould
{
    [Fact]
    public void AddKey()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        bool done = false;

        source.When(s => s.Add(key, value)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        unDoDictionary.Add(key, value);

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateAddDescription()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object key = new();
        object value = new();
        unDoCollection.Add(key, value);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryAdd);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(key);
        Check.That(description.Value.Parameters[1]).IsEqualTo(value);
    }
}
