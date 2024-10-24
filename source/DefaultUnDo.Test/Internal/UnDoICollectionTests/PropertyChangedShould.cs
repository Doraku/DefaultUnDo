using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoICollectionTests;

public sealed class PropertyChangedShould
{
    [Fact]
    public void AddEventWhenAdd()
    {
        ICollection<object> source = Substitute.For<ICollection<object>, INotifyPropertyChanged>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();
        PropertyChangedEventHandler handler = Substitute.For<PropertyChangedEventHandler>();

        bool done = false;

        ((INotifyPropertyChanged)source).When(s => s.PropertyChanged += handler).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        ((INotifyPropertyChanged)unDoCollection).PropertyChanged += handler;

        Check.That(done).IsTrue();
    }

    [Fact]
    public void RemoveEventWhenRemove()
    {
        ICollection<object> source = Substitute.For<ICollection<object>, INotifyPropertyChanged>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();
        PropertyChangedEventHandler handler = Substitute.For<PropertyChangedEventHandler>();

        bool done = false;

        ((INotifyPropertyChanged)source).When(s => s.PropertyChanged -= handler).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        ((INotifyPropertyChanged)unDoCollection).PropertyChanged -= handler;

        Check.That(done).IsTrue();
    }
}
