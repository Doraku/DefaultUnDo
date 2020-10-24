using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class IDictionaryExtensionTest
    {
        #region Methods

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            IDictionary<object, object> source = null;

            Check
                .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();

            Check
                .ThatCode(() => source.AsUnDo(null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void AsUnDo_Should_return_an_IDictionary()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            Check.That(source.AsUnDo(manager)).IsNotNull();
        }

        [Fact]
        public void UnDoDictionary_Add_key_Should_Add_key()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            bool done = false;

            source.When(s => s.Add(key, value)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            unDoDictionary.Add(key, value);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoDictionary_Add_Should_generate_Add_description()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            UnDoCollectionOperation? description = null;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

            object key = new object();
            object value = new object();
            unDoCollection.Add(key, value);

            Check.That(description.HasValue).IsTrue();
            Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
            Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryAdd);
            Check.That(description.Value.Parameters.Length).IsEqualTo(2);
            Check.That(description.Value.Parameters[0]).IsEqualTo(key);
            Check.That(description.Value.Parameters[1]).IsEqualTo(value);
        }

        [Fact]
        public void UnDoDictionary_ContainsKey_Should_return_ContainsKey()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();

            source.ContainsKey(key).Returns(true);

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary.ContainsKey(key)).IsEqualTo(source.ContainsKey(key));
        }

        [Fact]
        public void UnDoDictionary_Remove_key_Should_return_Remove_key()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            source.Remove(key).Returns(true);
            source.TryGetValue(key, out value).ReturnsForAnyArgs(true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary.Remove(key)).IsEqualTo(source.Remove(key));
        }

        [Fact]
        public void UnDoDictionary_Remove_Should_generate_Remove_description()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            UnDoCollectionOperation? description = null;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

            object key = new object();
            unDoCollection.Remove(key);

            Check.That(description.HasValue).IsTrue();
            Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
            Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryRemove);
            Check.That(description.Value.Parameters.Length).IsEqualTo(1);
            Check.That(description.Value.Parameters[0]).IsEqualTo(key);
        }

        [Fact]
        public void UnDoDictionary_TryGetValue_Should_return_TryGetValue()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            source.TryGetValue(key, out object value2).ReturnsForAnyArgs(c => { c[1] = value; return true; });

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary.TryGetValue(key, out object value1)).IsEqualTo(source.TryGetValue(key, out value2));
            Check.That(value1).IsEqualTo(value);
            Check.That(value1).IsEqualTo(value2);
        }

        [Fact]
        public void UnDoDictionary_this_key_get_Should_return_this_key_get()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            source[key].Returns(value);

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary[key]).IsEqualTo(source[key]);
        }

        [Fact]
        public void UnDoDictionary_this_key_set_Should_set_this_key_When_TryGetValue_is_true()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            bool done = false;

            source.TryGetValue(key, out value).ReturnsForAnyArgs(true);
            source.When(s => s[key] = value).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            unDoDictionary[key] = value;

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoDictionary_this_key_set_Should_set_this_key_When_TryGetValue_is_false()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            object key = new object();
            object value = new object();

            bool done = false;

            source.TryGetValue(key, out value).ReturnsForAnyArgs(false);
            source.When(s => s[key] = value).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            unDoDictionary[key] = value;

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoDictionary_this_key_set_Should_generate_this_description()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();

            UnDoCollectionOperation? description = null;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            IDictionary<object, object> unDoCollection = source.AsUnDo(manager, d => description = d);

            object key = new object();
            object value = new object();
            unDoCollection[key] = value;

            Check.That(description.HasValue).IsTrue();
            Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
            Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IDictionaryIndexer);
            Check.That(description.Value.Parameters.Length).IsEqualTo(2);
            Check.That(description.Value.Parameters[0]).IsEqualTo(key);
            Check.That(description.Value.Parameters[1]).IsEqualTo(value);
        }

        [Fact]
        public void UnDoDictionary_Keys_Should_return_Keys()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ICollection<object> keys = Substitute.For<ICollection<object>>();

            source.Keys.Returns(keys);

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary.Keys).IsEqualTo(source.Keys);
        }

        [Fact]
        public void UnDoDictionary_Values_Should_return_Values()
        {
            IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ICollection<object> values = Substitute.For<ICollection<object>>();

            source.Values.Returns(values);

            IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

            Check.That(unDoDictionary.Values).IsEqualTo(source.Values);
        }

        #endregion
    }
}
