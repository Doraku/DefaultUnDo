using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class CollectionChangedShould
{
    [Fact]
    public void AddEventWhenAdd()
    {
        ICollection<object> source = Substitute.For<ICollection<object>, INotifyCollectionChanged>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();
        NotifyCollectionChangedEventHandler handler = Substitute.For<NotifyCollectionChangedEventHandler>();

        bool done = false;

        ((INotifyCollectionChanged)source).When(s => s.CollectionChanged += handler).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        ((INotifyCollectionChanged)unDoCollection).CollectionChanged += handler;

        Check.That(done).IsTrue();
    }

    [Fact]
    public void RemoveEventWhenRemove()
    {
        ICollection<object> source = Substitute.For<ICollection<object>, INotifyCollectionChanged>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();
        NotifyCollectionChangedEventHandler handler = Substitute.For<NotifyCollectionChangedEventHandler>();

        bool done = false;

        ((INotifyCollectionChanged)source).When(s => s.CollectionChanged -= handler).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        ((INotifyCollectionChanged)unDoCollection).CollectionChanged -= handler;

        Check.That(done).IsTrue();
    }
}
