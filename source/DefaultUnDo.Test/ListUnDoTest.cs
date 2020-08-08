using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class ListUnDoTest
    {
        #region Tests

        [Fact]
        public void ListUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            Check
                .ThatCode(() => new ListUnDo<object>(null, 0, null, false))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void Do_Should_insert_element_to_source_When_isAdd_is_true()
        {
            const int index = 42;
            object value = new object();
            IList<object> source = Substitute.For<IList<object>>();
            IUnDo undo = new ListUnDo<object>(source, index, value, true);

            bool done = false;

            source.When(s => s.Insert(index, value)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Do_Should_remove_element_from_source_When_isAdd_is_false()
        {
            const int index = 42;
            object value = new object();
            IList<object> source = Substitute.For<IList<object>>();
            IUnDo undo = new ListUnDo<object>(source, index, value, false);

            bool done = false;

            source.When(s => s.RemoveAt(index)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_remove_element_from_source_When_isAdd_is_true()
        {
            const int index = 42;
            object value = new object();
            IList<object> source = Substitute.For<IList<object>>();
            IUnDo undo = new ListUnDo<object>(source, index, value, true);

            bool done = false;

            source.When(s => s.RemoveAt(index)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_insert_element_to_source_When_isAdd_is_false()
        {
            const int index = 42;
            object value = new object();
            IList<object> source = Substitute.For<IList<object>>();
            IUnDo undo = new ListUnDo<object>(source, index, value, false);

            bool done = false;

            source.When(s => s.Insert(index, value)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        #endregion
    }
}
