using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class UnDoManagerTest
    {
        #region Methods

        [Fact]
        public void Version_Should_incremente_When_a_command_is_done()
        {
            IUnDoManager manager = new UnDoManager();

            int oldVersion = manager.Version;

            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.Version).IsStrictlyGreaterThan(oldVersion);
        }

        [Fact]
        public void Version_Should_return_old_value_When_a_command_is_undone()
        {
            IUnDoManager manager = new UnDoManager();

            int oldVersion = manager.Version;

            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.Version).IsEqualTo(oldVersion);
        }

        [Fact]
        public void Version_Should_return_last_value_When_a_command_is_redone()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());

            int lastVersion = manager.Version;

            manager.Undo();
            manager.Redo();

            Check.That(manager.Version).IsEqualTo(lastVersion);
        }

        [Fact]
        public void CanUndo_Should_return_false_When_no_command_has_been_done()
        {
            IUnDoManager manager = new UnDoManager();

            Check.That(manager.CanUndo).IsFalse();
        }

        [Fact]
        public void CanUndo_Should_return_true_When_a_command_has_been_done()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.CanUndo).IsTrue();
        }

        [Fact]
        public void CanUndo_Should_return_false_When_all_commands_have_been_undone()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanUndo).IsFalse();
        }

        [Fact]
        public void CanRedo_Should_return_false_When_no_command_has_been_done()
        {
            IUnDoManager manager = new UnDoManager();

            Check.That(manager.CanRedo).IsFalse();
        }

        [Fact]
        public void CanRedo_Should_return_true_When_a_command_has_been_undone()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanRedo).IsTrue();
        }

        [Fact]
        public void CanRedo_Should_return_false_When_all_commands_have_been_redone()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();
            manager.Redo();

            Check.That(manager.CanRedo).IsFalse();
        }

        [Fact]
        public void Clear_Should_clear_undone_and_done_history()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanUndo).IsTrue();
            Check.That(manager.CanRedo).IsTrue();

            manager.Clear();

            Check.That(manager.CanUndo).IsFalse();
            Check.That(manager.CanRedo).IsFalse();
        }

        [Fact]
        public void Do_Should_throw_ArgumentNullException_When_command_is_null()
        {
            IUnDoManager manager = new UnDoManager();

            Check
                .ThatCode(() => manager.Do(null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "command");
        }

        [Fact]
        public void Do_Should_Do()
        {
            IUnDoManager manager = new UnDoManager();
            IUnDo undo = Substitute.For<IUnDo>();

            bool done = false;
            undo.When(u => u.Do()).Do(_ => done = true);

            manager.Do(undo);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Do_Should_not_add_command_in_history_when_a_group_is_going_on()
        {
            IUnDoManager manager = new UnDoManager();
            IUnDo undo = Substitute.For<IUnDo>();
            int version = manager.Version;

            using (manager.BeginGroup())
            {
                manager.Do(undo);

                Check.That(manager.Version).IsEqualTo(version);
            }
        }

        [Fact]
        public void BeginGroup_Should_return_an_IDisposable()
        {
            IUnDoManager manager = new UnDoManager();

            Check.That(manager.BeginGroup()).IsNotNull();
        }

        [Fact]
        public void BeginGroup_Should_add_commands_as_one_operation_in_history_once_disposed()
        {
            IUnDoManager manager = new UnDoManager();
            IUnDo undo = Substitute.For<IUnDo>();
            undo.Description.Returns("dummy");
            int version = manager.Version;

            using (manager.BeginGroup("first"))
            using (manager.BeginGroup("second"))
            {
                manager.Do(undo);
                manager.Do(undo);
            }

            Check.That(manager.Version).IsStrictlyGreaterThan(version);
            Check.That(manager.UndoDescriptions).ContainsExactly("first");

            manager.Undo();

            Check.That(manager.Version).IsEqualTo(version);
        }

        [Fact]
        public void Do_Should_clear_undone_history()
        {
            IUnDoManager manager = new UnDoManager();

            manager.Do(Substitute.For<IUnDo>());
            manager.Do(Substitute.For<IUnDo>());
            manager.Undo();

            Check.That(manager.CanRedo).IsTrue();

            manager.Do(Substitute.For<IUnDo>());

            Check.That(manager.CanRedo).IsFalse();
        }

        [Fact]
        public void Undo_Should_throw_InvalidOperationException_When_CanUndo_is_false()
        {
            IUnDoManager manager = new UnDoManager();

            Check
                .ThatCode(() => manager.Undo())
                .Throws<InvalidOperationException>();
        }

        [Fact]
        public void Undo_Should_throw_InvalidOperationException_When_a_group_operation_is_going_on()
        {
            IUnDoManager manager = new UnDoManager();

            using (manager.BeginGroup())
            {
                Check
                    .ThatCode(() => manager.Undo())
                    .Throws<InvalidOperationException>()
                    .WithMessage("Cannot perform Undo while a group operation is going on.");
            }
        }

        [Fact]
        public void Undo_Should_Undo()
        {
            IUnDoManager manager = new UnDoManager();
            IUnDo undo = Substitute.For<IUnDo>();

            bool done = false;
            undo.When(u => u.Undo()).Do(_ => done = true);

            manager.Do(undo);
            manager.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Redo_Should_throw_InvalidOperationException_When_CanRedo_is_false()
        {
            IUnDoManager manager = new UnDoManager();

            Check
                .ThatCode(() => manager.Redo())
                .Throws<InvalidOperationException>();
        }

        [Fact]
        public void Redo_Should_throw_InvalidOperationException_When_a_group_operation_is_going_on()
        {
            IUnDoManager manager = new UnDoManager();

            using (manager.BeginGroup())
            {
                Check
                    .ThatCode(() => manager.Redo())
                    .Throws<InvalidOperationException>()
                    .WithMessage("Cannot perform Redo while a group operation is going on.");
            }
        }

        [Fact]
        public void Redo_Should_Redo()
        {
            IUnDoManager manager = new UnDoManager();
            IUnDo undo = Substitute.For<IUnDo>();

            manager.Do(undo);
            manager.Undo();

            bool done = false;
            undo.When(u => u.Do()).Do(_ => done = true);

            manager.Redo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void PropertyChanged_Should_be_called()
        {
            IUnDoManager manager = new UnDoManager();
            List<string> properties = new List<string>();
            manager.PropertyChanged += (_, e) => properties.Add(e.PropertyName);

            manager.Do(null, null);

            Check.That(properties).Contains(nameof(manager.Version), nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));

            properties.Clear();

            manager.Clear();

            Check.That(properties).Contains(nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));
        }

        [Fact]
        public void UndoDescriptions_Should_return_descriptions_of_undoable_operations()
        {
            IUnDoManager manager = new UnDoManager();
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

        [Fact]
        public void RedoDescriptions_Should_return_descriptions_of_redoable_operations()
        {
            IUnDoManager manager = new UnDoManager();
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

        #endregion
    }
}
