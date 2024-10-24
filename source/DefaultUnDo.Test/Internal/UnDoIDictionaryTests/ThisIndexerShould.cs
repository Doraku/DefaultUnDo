using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class ThisIndexerShould
{
    [Fact]
    public void ReturnThisKeyGet()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        source[key].Returns(value);

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary[key]).IsEqualTo(source[key]);
    }

    [Fact]
    public void SetThisKeyWhenTryGetValueIsTrue()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        bool done = false;

        source.TryGetValue(key, out value).ReturnsForAnyArgs(true);
        source.When(s => s[key] = value).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        unDoDictionary[key] = value;

        Check.That(done).IsTrue();
    }

    [Fact]
    public void SetThisKeyWhenTryGetValueIsFalse()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        bool done = false;

        source.TryGetValue(key, out value).ReturnsForAnyArgs(false);
        source.When(s => s[key] = value).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        unDoDictionary[key] = value;

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateThisDescription()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

        object key = new();
        object value = new();
        unDoCollection[key] = value;

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryIndexer);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(key);
        Check.That(description.Value.Parameters[1]).IsEqualTo(value);
    }
}
