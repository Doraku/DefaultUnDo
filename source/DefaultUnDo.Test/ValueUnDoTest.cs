using System;
using NFluent;
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
            object oldValue = new object();
            object newValue = new object();
            IUnDo undo = new ValueUnDo<object>(v => value = v, newValue, oldValue);

            undo.Do();

            Check.That(value).IsEqualTo(newValue);
        }

        [Fact]
        public void Undo_Should_set_oldValue()
        {
            object value = null;
            object oldValue = new object();
            object newValue = new object();
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

        //[Fact]
        //public void TryMerge_Should_return_true_When_mergeable()
        //{
        //    int value = 1;

        //    void Set(int v) => value = v;

        //    ValueUnDo<int> unDo1 = new ValueUnDo<int>("test", Set, 2, 1);
        //    ValueUnDo<int> unDo2 = new ValueUnDo<int>("test", Set, 3, 2);

        //    Check.That(ValueUnDo<int>.TryMerge(unDo1, unDo2, TimeSpan.FromSeconds(1), out ValueUnDo<int> newUnDo)).IsTrue();

        //    ((IUnDo)newUnDo).Do();
        //    Check.That(value).IsEqualTo(3);

        //    ((IUnDo)newUnDo).Undo();
        //    Check.That(value).IsEqualTo(1);
        //}

        #endregion
    }
}
