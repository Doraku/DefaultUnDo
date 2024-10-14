using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo;

public sealed class ICollectionExtensionTest
{
    [Fact]
    public void AsUnDo_Should_throw_ArgumentNullException_When_source_is_null()
    {
        ICollection<int> source = null;

        Check
            .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void AsUnDo_Should_throw_ArgumentNullException_When_manager_is_null()
    {
        ICollection<int> source = Substitute.For<ICollection<int>>();

        Check
            .ThatCode(() => source.AsUnDo(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void AsUnDo_Should_return_an_ICollection()
    {
        ICollection<int> source = Substitute.For<ICollection<int>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        Check.That(source.AsUnDo(manager)).IsNotNull();
    }

    [Fact]
    public void UnDoCollection_Add_Should_Add()
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
    public void UnDoCollection_Add_Should_generate_Add_description()
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

    [Fact]
    public void UnDoCollection_Clear_Should_Clear()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        bool done = false;

        source.Count.Returns(42);
        source.When(s => s.Clear()).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        unDoCollection.Clear();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void UnDoCollection_Clear_Should_generate_Clear_description()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ICollection<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        unDoCollection.Clear();

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ICollectionClear);
        Check.That(description.Value.Parameters.Length).IsZero();
    }

    [Fact]
    public void UnDoCollection_Contains_Should_return_Contains()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object value = new();

        source.Contains(value).Returns(true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.Contains(value)).IsEqualTo(source.Contains(value));
    }

    [Fact]
    public void UnDoCollection_CopyTo_Should_CopyTo()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object[] values = [];
        const int index = 42;

        bool done = false;

        source.When(s => s.CopyTo(values, index)).Do(_ => done = true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        unDoCollection.CopyTo(values, index);

        Check.That(done).IsTrue();
    }

    [Fact]
    public void UnDoCollection_Count_Should_return_Count()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        source.Count.Returns(1337);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.Count).IsEqualTo(source.Count);
    }

    [Fact]
    public void UnDoCollection_IsReadOnly_Should_return_IsReadOnly()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        source.IsReadOnly.Returns(true);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.IsReadOnly).IsEqualTo(source.IsReadOnly);
    }

    [Fact]
    public void UnDoCollection_Remove_Should_return_Remove()
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
    public void UnDoCollection_Remove_Should_generate_Remove_description()
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

    [Fact]
    public void UnDoCollection_GetEnumerator_T_Should_return_GetEnumerator_T()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator<object> enumerator = Substitute.For<IEnumerator<object>>();

        source.GetEnumerator().Returns(enumerator);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(unDoCollection.GetEnumerator()).IsEqualTo(source.GetEnumerator());
    }

    [Fact]
    public void UnDoCollection_GetEnumerator_Should_return_GetEnumerator()
    {
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IEnumerator enumerator = Substitute.For<IEnumerator>();

        ((IEnumerable)source).GetEnumerator().Returns(enumerator);

        ICollection<object> unDoCollection = source.AsUnDo(manager);

        Check.That(((IEnumerable)unDoCollection).GetEnumerator()).IsEqualTo(((IEnumerable)source).GetEnumerator());
    }

    [Fact]
    public void UnDoCollection_CollectionChanged_add_Should_add_CollectionChanged()
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
    public void UnDoCollection_CollectionChanged_remove_Should_remove_CollectionChanged()
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

    [Fact]
    public void UnDoCollection_PropertyChanged_add_Should_add_PropertyChanged()
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
    public void UnDoCollection_PropertyChanged_remove_Should_remove_PropertyChanged()
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
