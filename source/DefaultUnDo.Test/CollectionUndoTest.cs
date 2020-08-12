using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class CollectionUndoTest
    {
        #region Tests

        [Fact]
        public void CollectionUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            Check
                .ThatCode(() => new CollectionUnDo<int>(null, 0, false))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void Do_Should_add_element_to_source_When_isAdd_is_true()
        {
            object value = new object();
            ICollection<object> source = Substitute.For<ICollection<object>>();
            IUnDo undo = new CollectionUnDo<object>(source, value, true);

            bool done = false;

            source.When(s => s.Add(value)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Do_Should_remove_element_from_source_When_isAdd_is_false()
        {
            object value = new object();
            ICollection<object> source = Substitute.For<ICollection<object>>();
            IUnDo undo = new CollectionUnDo<object>(source, value, false);

            bool done = false;

            source.When(s => s.Remove(value)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_remove_element_from_source_When_isAdd_is_true()
        {
            object value = new object();
            ICollection<object> source = Substitute.For<ICollection<object>>();
            IUnDo undo = new CollectionUnDo<object>(source, value, true);

            bool done = false;

            source.When(s => s.Remove(value)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_add_element_to_source_When_isAdd_is_false()
        {
            object value = new object();
            ICollection<object> source = Substitute.For<ICollection<object>>();
            IUnDo undo = new CollectionUnDo<object>(source, value, false);

            bool done = false;

            source.When(s => s.Add(value)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Description_Should_return_description()
        {
            IUnDo undo = new CollectionUnDo<object>("test", Substitute.For<ICollection<object>>(), null, true);

            Check.That(undo.Description).IsEqualTo("test");
        }

        #endregion
    }
}
