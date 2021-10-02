using System;
using System.Threading;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class ValueUnDoTest
    {
        #region Tests

        [Fact]
        public void ValueUnDo_Should_throw_ArgumentNullException_When_setter_is_null()
        {
            Check
                .ThatCode(() => new ValueUnDo<object>(null, null, null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "setter");
        }

        [Fact]
        public void Do_Should_set_newValue()
        {
            object value = null;
            object oldValue = new();
            object newValue = new();
            IUnDo undo = new ValueUnDo<object>(v => value = v, newValue, oldValue);

            undo.Do();

            Check.That(value).IsEqualTo(newValue);
        }

        [Fact]
        public void Undo_Should_set_oldValue()
        {
            object value = null;
            object oldValue = new();
            object newValue = new();
            IUnDo undo = new ValueUnDo<object>(v => value = v, newValue, oldValue);

            undo.Undo();

            Check.That(value).IsEqualTo(oldValue);
        }

        [Fact]
        public void Description_Should_return_description()
        {
            IUnDo undo = new ValueUnDo<object>("test", _ => { }, null, null);

            Check.That(undo.Description).IsEqualTo("test");
        }

        [Fact]
        public void TryMerge_Should_return_false_When_other_is_not_ValueUnDo()
        {
            IMergeableUnDo value = new ValueUnDo<int>("test", _ => { }, 0, 0);
            IUnDo undo = Substitute.For<IUnDo>();
            undo.Description.Returns("test");

            Check.That(value.TryMerge(undo, out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_false_When_other_is_not_GroupUnDo_with_single_ValueUnDo()
        {
            IMergeableUnDo value = new ValueUnDo<int>("test", _ => { }, 0, 0);
            IUnDo undo = Substitute.For<IUnDo>();
            undo.Description.Returns("test");

            Check.That(value.TryMerge(new GroupUnDo("test", undo), out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_false_When_setter_are_different()
        {
            IMergeableUnDo value = new ValueUnDo<int>("test", Substitute.For<Action<int>>(), 0, 0);

            Check.That(value.TryMerge(new ValueUnDo<int>("test", Substitute.For<Action<int>>(), 0, 0), out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_false_When_newValue_and_oldValue_are_different()
        {
            Action<int> setter = Substitute.For<Action<int>>();
            IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 1);

            Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 2), out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_false_When_timestamp_are_too_far()
        {
            Action<int> setter = Substitute.For<Action<int>>();
            IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

            Thread.Sleep(1000);

            Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_true_When_merged_with_ValueUnDo()
        {
            int item = 0;
            void setter(int v) => item = v;
            IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

            Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out IUnDo merged)).IsTrue();
            Check.That(merged.Description).IsEqualTo(value.Description);

            merged.Do();
            Check.That(item).IsEqualTo(2);
            merged.Undo();
            Check.That(item).IsEqualTo(0);
        }

        [Fact]
        public void TryMerge_Should_return_true_When_merged_with_GroupUnDo()
        {
            int item = 0;
            void setter(int v) => item = v;
            IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

            Check.That(value.TryMerge(new GroupUnDo("test", new ValueUnDo<int>("test", setter, 2, 1)), out IUnDo merged)).IsTrue();
            Check.That(merged.Description).IsEqualTo(value.Description);

            merged.Do();
            Check.That(item).IsEqualTo(2);
            merged.Undo();
            Check.That(item).IsEqualTo(0);
        }

        #endregion
    }
}
