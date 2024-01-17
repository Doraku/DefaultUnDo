using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class UnDoManagerTest
    {
        public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

        [Fact]
        public void UnDoManager_maxCapacity_Should_throw_ArgumentException_When_maxCapacity_is_inferior_or_equal_to_zero()
        {
            Check.ThatCode(() => new UnDoManager(-1)).Throws<ArgumentException>();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Version_Should_incremente_When_a_command_is_done(IUnDoManager manager)
        {
            int oldVersion = manager.Version;

            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.Version).IsStrictlyGreaterThan(oldVersion);
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Version_Should_return_old_value_When_a_command_is_undone(IUnDoManager manager)
        {
            int oldVersion = manager.Version;

            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.Version).IsEqualTo(oldVersion);
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Version_Should_return_last_value_When_a_command_is_redone(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());

            int lastVersion = manager.Version;

            manager.Undo();
            manager.Redo();

            Check.That(manager.Version).IsEqualTo(lastVersion);
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanUndo_Should_return_false_When_no_command_has_been_done(IUnDoManager manager)
        {
            Check.That(manager.CanUndo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanUndo_Should_return_true_When_a_command_has_been_done(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.CanUndo).IsTrue();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanUndo_Should_return_false_When_all_commands_have_been_undone(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanUndo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanRedo_Should_return_false_When_no_command_has_been_done(IUnDoManager manager)
        {
            Check.That(manager.CanRedo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanRedo_Should_return_true_When_a_command_has_been_undone(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanRedo).IsTrue();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void CanRedo_Should_return_false_When_all_commands_have_been_redone(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();
            manager.Redo();

            Check.That(manager.CanRedo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Clear_Should_clear_undone_and_done_history(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanUndo).IsTrue();
            Check.That(manager.CanRedo).IsTrue();

            manager.Clear();

            Check.That(manager.CanUndo).IsFalse();
            Check.That(manager.CanRedo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Clear_Should_throw_When_a_transaction_is_going_on(IUnDoManager manager)
        {
            IUnDoTransaction transaction = manager.BeginTransaction();

            Check.ThatCode(manager.Clear).Throws<InvalidOperationException>();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Do_Should_throw_ArgumentNullException_When_command_is_null(IUnDoManager manager)
        {
            Check
                .ThatCode(() => manager.Do(null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "command");
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Do_Should_Do(IUnDoManager manager)
        {
            IUnDo undo = Substitute.For<IUnDo>();

            bool done = false;
            undo.When(u => u.Do()).Do(_ => done = true);

            manager.Do(undo);

            Check.That(done).IsTrue();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Do_Should_merge_When_possible(IUnDoManager manager)
        {
            IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
            IUnDo undo = Substitute.For<IUnDo>();
            IUnDo merged = Substitute.For<IUnDo>();
            merged.Description.Returns("yay");

            mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
            {
                x[1] = merged;
                return true;
            });

            manager.Do(mergeable);
            manager.Do(undo);

            Check.That(manager.UndoDescriptions).ContainsExactly("yay");
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Do_Should_not_add_command_in_history_when_a_group_is_going_on(IUnDoManager manager)
        {
            IUnDo undo = Substitute.For<IUnDo>();
            int version = manager.Version;

            using (manager.BeginTransaction())
            {
                manager.Do(undo);

                Check.That(manager.Version).IsEqualTo(version);
            }
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void BeginTransaction_Should_return_an_IDisposable(IUnDoManager manager)
        {
            Check.That(manager.BeginTransaction()).IsNotNull();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void BeginTransaction_Should_add_commands_as_one_operation_in_history_once_disposed(IUnDoManager manager)
        {
            IUnDo undo = Substitute.For<IUnDo>();
            undo.Description.Returns("dummy");
            int version = manager.Version;

            using (IUnDoTransaction t1 = manager.BeginTransaction("first"))
            using (IUnDoTransaction t2 = manager.BeginTransaction("second"))
            {
                manager.Do(undo);
                manager.Do(undo);

                t2.Commit();
                t1.Commit();
            }

            Check.That(manager.Version).IsStrictlyGreaterThan(version);
            Check.That(manager.UndoDescriptions).ContainsExactly("first");

            manager.Undo();

            Check.That(manager.Version).IsEqualTo(version);
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Do_Should_clear_undone_history(IUnDoManager manager)
        {
            manager.Do(Substitute.For<IUnDo>());
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanRedo).IsTrue();

            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.CanRedo).IsFalse();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Undo_Should_throw_InvalidOperationException_When_CanUndo_is_false(IUnDoManager manager)
        {
            Check
                .ThatCode(manager.Undo)
                .Throws<InvalidOperationException>();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Undo_Should_throw_InvalidOperationException_When_a_transaction_is_going_on(IUnDoManager manager)
        {
            using (manager.BeginTransaction())
            {
                Check
                    .ThatCode(manager.Undo)
                    .Throws<InvalidOperationException>()
                    .WithMessage("Cannot perform Undo while a transaction is going on.");
            }
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Undo_Should_Undo(IUnDoManager manager)
        {
            IUnDo undo = Substitute.For<IUnDo>();

            bool done = false;
            undo.When(u => u.Undo()).Do(_ => done = true);

            manager.Do(undo);
            manager.Undo();

            Check.That(done).IsTrue();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Redo_Should_throw_InvalidOperationException_When_CanRedo_is_false(IUnDoManager manager)
        {
            Check
                .ThatCode(manager.Redo)
                .Throws<InvalidOperationException>();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Redo_Should_throw_InvalidOperationException_When_a_transaction_is_going_on(IUnDoManager manager)
        {
            using (manager.BeginTransaction())
            {
                Check
                    .ThatCode(manager.Redo)
                    .Throws<InvalidOperationException>()
                    .WithMessage("Cannot perform Redo while a transaction is going on.");
            }
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void Redo_Should_Redo(IUnDoManager manager)
        {
            IUnDo undo = Substitute.For<IUnDo>();

            manager.Do(undo);
            manager.Undo();

            bool done = false;
            undo.When(u => u.Do()).Do(_ => done = true);

            manager.Redo();

            Check.That(done).IsTrue();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void PropertyChanged_Should_be_called(IUnDoManager manager)
        {
            List<string> properties = [];
            manager.PropertyChanged += (_, e) => properties.Add(e.PropertyName);

            manager.Do(() => { }, () => { });

            Check.That(properties).Contains(nameof(manager.Version), nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));

            properties.Clear();

            manager.Clear();

            Check.That(properties).Contains(nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void UndoDescriptions_Should_return_descriptions_of_undoable_operations(IUnDoManager manager)
        {
            IUnDo operation1 = Substitute.For<IUnDo>();
            IUnDo operation2 = Substitute.For<IUnDo>();

            operation1.Description.Returns("kikoo");
            operation2.Description.Returns("lol");

            manager.Do(operation1);
            manager.Do(operation2);

            Check.That(manager.UndoDescriptions).ContainsExactly("lol", "kikoo");

            manager.Undo();
            manager.Undo();

            Check.That(manager.UndoDescriptions).IsEmpty();
        }

        [Theory]
        [MemberData(nameof(UnDoManagers))]
        public void RedoDescriptions_Should_return_descriptions_of_redoable_operations(IUnDoManager manager)
        {
            IUnDo operation1 = Substitute.For<IUnDo>();
            IUnDo operation2 = Substitute.For<IUnDo>();

            operation1.Description.Returns("kikoo");
            operation2.Description.Returns("lol");

            manager.Do(operation1);
            manager.Do(operation2);

            Check.That(manager.RedoDescriptions).IsEmpty();

            manager.Undo();
            manager.Undo();

            Check.That(manager.RedoDescriptions).ContainsExactly("kikoo", "lol");
        }

        [Fact]
        public void Do_Should_override_oldest_operation_When_max_capacity()
        {
            IUnDoManager manager = new UnDoManager(2);

            IUnDo operation1 = Substitute.For<IUnDo>();
            IUnDo operation2 = Substitute.For<IUnDo>();
            IUnDo operation3 = Substitute.For<IUnDo>();

            operation1.Description.Returns("un");
            operation2.Description.Returns("dos");
            operation3.Description.Returns("tres");

            manager.Do(operation1);
            manager.Do(operation2);
            manager.Do(operation3);

            Check.That(manager.UndoDescriptions).ContainsExactly("tres", "dos");

            manager.Undo();
            manager.Undo();

            Check.That(manager.RedoDescriptions).ContainsExactly("dos", "tres");

            manager.Redo();
            manager.Redo();

            Check.That(manager.UndoDescriptions).ContainsExactly("tres", "dos");
        }

        [Fact]
        public void Do_Should_operation_When_max_capacity_is_one()
        {
            IUnDoManager manager = new UnDoManager(1);

            IUnDo operation1 = Substitute.For<IUnDo>();
            IUnDo operation2 = Substitute.For<IUnDo>();

            operation1.Description.Returns("kikoo");
            operation2.Description.Returns("lol");

            manager.Do(operation1);
            manager.Do(operation2);

            Check.That(manager.UndoDescriptions).ContainsExactly("lol");
            Check.That(manager.RedoDescriptions).IsEmpty();

            manager.Undo();

            Check.That(manager.UndoDescriptions).IsEmpty();
            Check.That(manager.RedoDescriptions).ContainsExactly("lol");
        }

        [Fact]
        public void IUnDoTransactionCommit_Should_throw_When_already_disposed()
        {
            IUnDoManager manager = new UnDoManager(1);

            IUnDoTransaction transaction = manager.BeginTransaction();

            transaction.Dispose();

            Check.ThatCode(transaction.Commit).Throws<ObjectDisposedException>();
        }

        [Fact]
        public void IUnDoTransactionCommit_Should_throw_When_already_committed()
        {
            IUnDoManager manager = new UnDoManager(1);

            IUnDoTransaction transaction = manager.BeginTransaction();

            transaction.Commit();

            Check.ThatCode(transaction.Commit).Throws<InvalidOperationException>();
        }

        [Fact]
        public void IUnDoTransactionCommit_Should_throw_When_not_the_latest_transaction()
        {
            IUnDoManager manager = new UnDoManager(1);

            IUnDoTransaction transaction1 = manager.BeginTransaction();
            IUnDoTransaction transaction2 = manager.BeginTransaction();

            Check.ThatCode(transaction1.Commit).Throws<InvalidOperationException>();
        }

        [Fact]
        public void IUnDoTransactionDispose_Should_throw_When_not_the_latest_transaction()
        {
            IUnDoManager manager = new UnDoManager(1);

            IUnDoTransaction transaction1 = manager.BeginTransaction();
            IUnDoTransaction transaction2 = manager.BeginTransaction();

            Check.ThatCode(transaction1.Dispose).Throws<InvalidOperationException>();
        }

        [Fact]
        public void IUnDoTransactionDispose_Should_not_undo_When_committed()
        {
            IUnDoManager manager = new UnDoManager(1);

            bool unDone = false;

            using (IUnDoTransaction transaction = manager.BeginTransaction())
            {
                IUnDo undo = Substitute.For<IUnDo>();
                undo.When(u => u.Undo()).Do(_ => unDone = true);

                manager.Do(undo);

                transaction.Commit();
            }

            Check.That(unDone).IsFalse();
        }

        [Fact]
        public void IUnDoTransactionDispose_Should_undo_When_not_committed()
        {
            IUnDoManager manager = new UnDoManager(1);

            bool unDone = false;

            using (IUnDoTransaction transaction = manager.BeginTransaction())
            {
                IUnDo undo = Substitute.For<IUnDo>();
                undo.When(u => u.Undo()).Do(_ => unDone = true);

                manager.Do(undo);
            }

            Check.That(unDone).IsTrue();
        }
    }
}
