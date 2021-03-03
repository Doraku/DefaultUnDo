using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class IListExtensionTest
    {
        #region Tests

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IList<int> source = null;

            Check
                .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IList<int> source = Substitute.For<IList<int>>();

            Check
                .ThatCode(() => source.AsUnDo(null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void UnDoList_IndexOf_Should_return_IndexOf()
        {
            IList<object> source = Substitute.For<IList<object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object value = new();

            source.IndexOf(value).Returns(42);

            IList<object> unDoList = source.AsUnDo(manager);

            Check.That(unDoList.IndexOf(value)).IsEqualTo(source.IndexOf(value));
        }

        [Fact]
        public void UnDoList_Insert_Should_Insert()
        {
            IList<object> source = Substitute.For<IList<object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            const int index = 42;
            object value = new();

            bool done = false;

            source.When(s => s.Insert(index, value)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IList<object> unDoList = source.AsUnDo(manager);

            unDoList.Insert(index, value);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoList_Insert_Should_generate_Insert_description()
        {
            IList<object> source = Substitute.For<IList<object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            UnDoCollectionOperation? description = null;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IList<object> unDoCollection = source.AsUnDo(manager, d => description = d);

            const int index = 42;
            object item = new();
            unDoCollection.Insert(index, item);

            Check.That(description.HasValue).IsTrue();
            Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
            Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListInsert);
            Check.That(description.Value.Parameters.Length).IsEqualTo(2);
            Check.That(description.Value.Parameters[0]).IsEqualTo(index);
            Check.That(description.Value.Parameters[1]).IsEqualTo(item);
        }

        [Fact]
        public void UnDoList_RemoveAt_Should_RemoveAt()
        {
            IList<object> source = Substitute.For<IList<object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            const int index = 42;

            bool done = false;

            source.When(s => s.RemoveAt(index)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IList<object> unDoList = source.AsUnDo(manager);

            unDoList.RemoveAt(index);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoList_RemoveAt_Should_generate_RemoveAt_description()
        {
            IList<object> source = Substitute.For<IList<object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            UnDoCollectionOperation? description = null;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IList<object> unDoCollection = source.AsUnDo(manager, d => description = d);

            const int index = 42;
            unDoCollection.RemoveAt(index);

            Check.That(description.HasValue).IsTrue();
            Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
            Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListRemoveAt);
            Check.That(description.Value.Parameters.Length).IsEqualTo(1);
            Check.That(description.Value.Parameters[0]).IsEqualTo(index);
        }

        [Fact]
        public void UnDoList_this_index_get_Should_return_this_index_get()
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
        public void UnDoList_this_index_set_Should_set_this_index()
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
        public void UnDoList_this_index_set_Should_generate_this_description()
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

        [Fact]
        public void Move_Should_move_item()
        {
            List<int> items = new() { 1, 2 };

            items.Move(0, 1);

            Check.That(items).ContainsExactly(2, 1);
        }

        [Fact]
        public void Move_Should_move_item_as_UnDo_operation_When_UnDoList()
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
        public void Move_Should_set_description_as_Move()
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

        #endregion
    }
}
