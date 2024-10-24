using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIListTests;

public sealed class MoveShould
{
    [Fact]
    public void ThrowWhenSourceIsNull()
    {
        IList<int> items = null;

        Check.ThatCode(() => items.Move(0, 1)).Throws<ArgumentNullException>();
    }

    [Fact]
    public void MoveItem()
    {
        List<int> items = [1, 2];

        items.Move(0, 1);

        Check.That(items).ContainsExactly(2, 1);
    }

    [Fact]
    public void MoveItemAsUnDoOperationWhenUnDoList()
    {
        IUnDoManager manager = new UnDoManager();

        IList<int> items = new List<int> { 1, 2 }.AsUnDo(manager);

        items.Move(0, 1);

        Check.That(items).ContainsExactly(2, 1);

        manager.Undo();

        Check.That(items).ContainsExactly(1, 2);

        items = new ObservableCollection<int> { 1, 2 }.AsUnDo(manager);

        items.Move(0, 1);

        Check.That(items).ContainsExactly(2, 1);

        manager.Undo();

        Check.That(items).ContainsExactly(1, 2);
    }

    [Fact]
    public void SetDescriptionAsMove()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));
        UnDoCollectionOperation? description = null;

        IList<int> unDoCollection = new ObservableCollection<int> { 1, 2 }.AsUnDo(manager, a => description ??= a);

        unDoCollection.Move(0, 1);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListMove);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(0);
        Check.That(description.Value.Parameters[1]).IsEqualTo(1);

        description = null;
        unDoCollection = Substitute.For<IList<int>>().AsUnDo(manager, a => description ??= a);

        unDoCollection.Move(42, 43);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListMove);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(42);
        Check.That(description.Value.Parameters[1]).IsEqualTo(43);
    }
}
