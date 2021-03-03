using System;
using System.Collections.Generic;
using System.Linq;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class IUnDoManagerExtensionTest
    {
        #region Tests

        [Fact]
        public void DoAdd_ISet_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            ISet<object> source = null;

            Check
                .ThatCode(() => manager.DoAdd(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoAdd_ISet_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<object> source = null;

            Check
                .ThatCode(() => manager.DoAdd(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoAdd_ICollection_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoAdd(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoAdd_ICollection_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoAdd(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoAdd_ICollection_Should_keep_index_When_source_is_IList()
        {
            IUnDoManager manager = new UnDoManager();
            ICollection<int> source = new List<int> { 0, 1 };

            manager.DoAdd(source, 2);

            source.Add(3);

            manager.Undo();

            Check.That(source).ContainsExactly(0, 1, 3);

            manager.Redo();

            Check.That(source).ContainsExactly(0, 1, 2, 3);
        }

        [Fact]
        public void DoClear_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoClear(source))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoClear_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoClear(source))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoClear_Should_add_old_elements_When_undone()
        {
            ICollection<object> source = new List<object>
            {
                new object(),
                new object(),
                new object()
            };
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IUnDo undo = null;
            List<object> sourceCopy = source.ToList();

            manager.Do(Arg.Do<IUnDo>(i => undo = i));

            manager.DoClear(source);

            Check.That(undo).IsNotNull();

            undo.Do();

            Check.That(source.Count).IsEqualTo(0);

            undo.Undo();

            Check.That(source).ContainsExactly(sourceCopy);
        }

        [Fact]
        public void DoRemove_ICollection_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoRemove(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoRemove_ICollection_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ICollection<object> source = null;

            Check
                .ThatCode(() => manager.DoRemove(source, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoRemove_ICollection_Should_keep_index_When_source_is_IList()
        {
            IUnDoManager manager = new UnDoManager();
            ICollection<int> source = new List<int> { 0, 1 };

            manager.DoRemove(source, 0);

            manager.Undo();

            Check.That(source).ContainsExactly(0, 1);
        }

        [Fact]
        public void DoAdd_IDictionary_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.DoAdd(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoAdd_IDictionary_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.DoAdd(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoAdd_IDictionary_Should_throw_ArgumentNullException_When_key_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            object key = null;

            Check
                .ThatCode(() => manager.DoAdd(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "key");
        }

        [Fact]
        public void DoRemove_IDictionary_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.DoRemove(source, key))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoRemove_IDictionary_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.DoRemove(source, key))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoRemove_IDictionary_Should_throw_ArgumentNullException_When_key_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            object key = null;

            Check
                .ThatCode(() => manager.DoRemove(source, key))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "key");
        }

        [Fact]
        public void Do_IDictionary_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.Do(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void Do_IDictionary_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = null;
            object key = null;

            Check
                .ThatCode(() => manager.Do(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void Do_IDictionary_Should_throw_ArgumentNullException_When_key_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            object key = null;

            Check
                .ThatCode(() => manager.Do(source, key, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "key");
        }

        [Fact]
        public void Do_IDictionary_Should_remove_element_When_undone()
        {
            object key = new();
            IDictionary<object, object> source = new Dictionary<object, object>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IUnDo undo = null;

            manager.Do(Arg.Do<IUnDo>(i => undo = i));

            manager.Do(source, key, null);

            Check.That(undo).IsNotNull();

            undo.Do();

            Check.That(source.ContainsKey(key)).IsTrue();

            undo.Undo();

            Check.That(source.ContainsKey(key)).IsFalse();
        }

        [Fact]
        public void DoInsert_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IList<object> source = null;

            Check
                .ThatCode(() => manager.DoInsert(source, 0, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoInsert_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IList<object> source = null;

            Check
                .ThatCode(() => manager.DoInsert(source, 0, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DoRemoveAt_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IList<object> source = null;

            Check
                .ThatCode(() => manager.DoRemoveAt(source, 0))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void DoRemoveAt_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IList<object> source = null;

            Check
                .ThatCode(() => manager.DoRemoveAt(source, 0))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void Do_IList_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            IList<object> source = null;

            Check
                .ThatCode(() => manager.Do(source, 0, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void Do_IList_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IList<object> source = null;

            Check
                .ThatCode(() => manager.Do(source, 0, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void Do_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            Action doAction = null;
            Action undoAction = null;

            Check
                .ThatCode(() => manager.Do(doAction, undoAction))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void Do_Should_no_do_anything_When_both_actions_are_null()
        {
            IUnDoManager manager = new UnDoManager();
            Action doAction = null;
            Action undoAction = null;

            manager.Do(doAction, undoAction);

            Check.That(manager.CanUndo).IsFalse();
        }

        [Fact]
        public void DoOnDo_Should_call_action()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IUnDo undo = null;
            bool done = false;

            manager.Do(Arg.Do<IUnDo>(i => undo = i));
            manager.DoOnDo(() => done = true);

            Check.That(undo).IsNotNull();
            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void DoOnUnDo_Should_call_action()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            IUnDo undo = null;
            bool done = false;

            manager.Do(Arg.Do<IUnDo>(i => undo = i));
            manager.DoOnUndo(() => done = true);

            Check.That(undo).IsNotNull();
            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Do_ValueUnDo_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IUnDoManager manager = null;
            Action<object> setter = null;

            Check
                .ThatCode(() => manager.Do(setter, null, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void Do_ValueUnDo_Should_throw_ArgumentNullException_When_setter_is_null()
        {
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            Action<object> setter = null;

            Check
                .ThatCode(() => manager.Do(setter, null, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "setter");
        }

        #endregion
    }
}
