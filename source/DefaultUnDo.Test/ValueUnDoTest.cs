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

        #endregion
    }
}
