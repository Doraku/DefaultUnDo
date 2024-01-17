using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class GroupUnDoTest
    {
        [Fact]
        public void GroupUnDo_Should_throw_ArgumentNullException_When_commands_is_null()
        {
            Check
                .ThatCode(() => new GroupUnDo(default))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "commands");
        }

        [Fact]
        public void GroupUnDo_Should_throw_ArgumentNullException_When_commands_empty()
        {
            Check
                .ThatCode(() => new GroupUnDo())
                .Throws<ArgumentException>()
                .WithProperty("ParamName", "commands");
        }

        [Fact]
        public void GroupUnDo_Should_throw_ArgumentNullException_When_commands_contains_null()
        {
            Check
                .ThatCode(() => new GroupUnDo(new IUnDo[] { null }))
                .Throws<ArgumentException>()
                .WithProperty("ParamName", "commands");
        }

        [Fact]
        public void Do_Should_execute_children_Do()
        {
            List<IUnDo> done = [];

            IUnDo undo1 = Substitute.For<IUnDo>();
            undo1.When(u => u.Do()).Do(_ => done.Add(undo1));

            IUnDo undo2 = Substitute.For<IUnDo>();
            undo2.When(u => u.Do()).Do(_ => done.Add(undo2));

            IUnDo undo = new GroupUnDo(
                undo1,
                undo2);

            undo.Do();

            Check.That(done).ContainsExactly(undo1, undo2);
        }

        [Fact]
        public void Undo_Should_execute_children_Undo_in_reverse()
        {
            List<IUnDo> done = [];

            IUnDo undo1 = Substitute.For<IUnDo>();
            undo1.When(u => u.Undo()).Do(_ => done.Add(undo1));

            IUnDo undo2 = Substitute.For<IUnDo>();
            undo2.When(u => u.Undo()).Do(_ => done.Add(undo2));

            IUnDo undo = new GroupUnDo(
                undo1,
                undo2);

            undo.Undo();

            Check.That(done).ContainsExactly(undo2, undo1);
        }

        [Fact]
        public void Description_Should_return_description()
        {
            IUnDo undo = new GroupUnDo("test", Substitute.For<IUnDo>());

            Check.That(undo.Description).IsEqualTo("test");
        }

        [Fact]
        public void TryGetSingle_Should_return_false_When_multile_children()
        {
            GroupUnDo group = new(
                Substitute.For<IUnDo>(),
                Substitute.For<IUnDo>());

            Check.That(group.TryGetSingle<IUnDo>(out _)).IsFalse();
        }

        [Fact]
        public void TryGetSingle_Should_return_false_When_single_child_is_not_T()
        {
            GroupUnDo group = new(Substitute.For<IUnDo>());

            Check.That(group.TryGetSingle<IMergeableUnDo>(out _)).IsFalse();
        }

        [Fact]
        public void TryGetSingle_Should_return_true_When_single_child_is_T()
        {
            IUnDo undo = Substitute.For<IUnDo>();
            GroupUnDo group = new(undo);

            Check.That(group.TryGetSingle(out IUnDo found)).IsTrue();
            Check.That(found).IsEqualTo(undo);
        }

        [Fact]
        public void TryMerge_Should_return_false_When_group_is_not_single_IMergeableUnDo()
        {
            IMergeableUnDo group = new GroupUnDo("test", Substitute.For<IUnDo>());
            IUnDo undo = Substitute.For<IUnDo>();
            undo.Description.Returns("test");

            Check.That(group.TryMerge(undo, out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_false_When_single_IMergeableUnDo_do_not_merge()
        {
            IUnDo undo = Substitute.For<IUnDo>();
            IMergeableUnDo group = new GroupUnDo("test", Substitute.For<IMergeableUnDo>());
            undo.Description.Returns("test");

            Check.That(group.TryMerge(undo, out _)).IsFalse();
        }

        [Fact]
        public void TryMerge_Should_return_true_When_merged()
        {
            IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
            IUnDo undo = Substitute.For<IUnDo>();
            IMergeableUnDo group = new GroupUnDo("test", mergeable);
            undo.Description.Returns("test");
            mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
            {
                x[1] = undo;
                return true;
            });

            Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
            Check.That(merged.Description).IsEqualTo(group.Description);

            IUnDo newUndo = null;
            (merged as GroupUnDo)?.TryGetSingle(out newUndo);

            Check.That(newUndo).IsEqualTo(undo);
        }

        [Fact]
        public void TryMerge_Should_use_group_description()
        {
            IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
            IUnDo undo = Substitute.For<IUnDo>();
            IMergeableUnDo group = new GroupUnDo("test", mergeable);
            undo.Description.Returns("test1");
            mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
            {
                x[1] = undo;
                return true;
            });
            Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
            Check.That(merged.Description).IsEqualTo(group.Description);
        }

        [Fact]
        public void TryMerge_Should_use_MergeDescriptionAction_When_set()
        {
            IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
            IUnDo undo = Substitute.For<IUnDo>();
            IMergeableUnDo group = new GroupUnDo("test", mergeable);
            undo.Description.Returns("test");
            mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
            {
                x[1] = undo;
                return true;
            });
            GroupUnDo.MergeDescriptionAction = (_, _, _) => "kikoo";

            Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
            Check.That(merged.Description).IsEqualTo("kikoo");

            GroupUnDo.MergeDescriptionAction = null;
        }
    }
}
