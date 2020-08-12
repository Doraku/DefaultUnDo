using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class DictionaryUnDoTest
    {
        #region Tests

        [Fact]
        public void DictionaryUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            Check
                .ThatCode(() => new DictionaryUnDo<object, object>(null, new object(), 0, false))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void DictionaryUnDo_Should_throw_ArgumentNullException_When_key_is_null()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();

            Check
                .ThatCode(() => new DictionaryUnDo<object, object>(source, null, 0, false))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "key");
        }

        [Fact]
        public void Do_Should_add_element_to_source_When_isAdd_is_true()
        {
            object key = new object();
            object value = new object();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, true);

            bool done = false;

            source.When(s => s.Add(key, value)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Do_Should_remove_element_from_source_When_isAdd_is_false()
        {
            object key = new object();
            object value = new object();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, false);

            bool done = false;

            source.When(s => s.Remove(key)).Do(_ => done = true);

            undo.Do();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_remove_element_from_source_When_isAdd_is_true()
        {
            object key = new object();
            object value = new object();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, true);

            bool done = false;

            source.When(s => s.Remove(key)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Undo_Should_add_element_to_source_When_isAdd_is_false()
        {
            object key = new object();
            object value = new object();
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, false);

            bool done = false;

            source.When(s => s.Add(key, value)).Do(_ => done = true);

            undo.Undo();

            Check.That(done).IsTrue();
        }

        [Fact]
        public void Description_Should_return_description()
        {
            object key = new object();
            IUnDo undo = new DictionaryUnDo<object, object>("test", Substitute.For<IDictionary<object, object>>(), key, null, true);

            Check.That(undo.Description).IsEqualTo("test");
        }

        #endregion
    }
}
