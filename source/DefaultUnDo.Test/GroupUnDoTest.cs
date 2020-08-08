using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class GroupUnDoTest
    {
        #region Tests

        [Fact]
        public void GroupUnDo_Should_throw_ArgumentNullException_When_commands_is_null()
        {
            Check
                .ThatCode(() => new GroupUnDo(null))
                .Throws<ArgumentNullException>()
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
            List<IUnDo> done = new List<IUnDo>();

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
            List<IUnDo> done = new List<IUnDo>();

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

        #endregion
    }
}
