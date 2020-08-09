using System;
using System.Collections.Generic;
using System.Linq;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Test
{
    public sealed class ISetExtensionTest
    {
        #region Tests

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_source_is_null()
        {
            ISet<int> source = null;

            Check
                .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "source");
        }

        [Fact]
        public void AsUnDo_Should_throw_ArgumentNullException_When_manager_is_null()
        {
            ISet<int> source = Substitute.For<ISet<int>>();

            Check
                .ThatCode(() => source.AsUnDo(null))
                .Throws<ArgumentNullException>()
                .WithProperty("ParamName", "manager");
        }

        [Fact]
        public void UnDoSet_Add_Should_return_true_When_added()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            manager.Do(Arg.Do<IUnDo>(i => i.Do()));
            source.When(s => ((ICollection<int>)s).Add(42)).Do(_ => done = true);

            source.Contains(42).Returns(false);
            Check.That(unDoSet.Add(42)).IsTrue();
            Check.That(done).IsTrue();

            done = false;
            source.Contains(42).Returns(true);
            Check.That(unDoSet.Add(42)).IsFalse();
            Check.That(done).IsFalse();
        }

        [Fact]
        public void UnDoSet_ExceptWith_Should_()
        {
            IUnDoManager manager = new UnDoManager();
            ISet<int> unDoSet = new HashSet<int> { 1, 2, 3 }.AsUnDo(manager);

            unDoSet.ExceptWith(new[] { 2 });

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 3);

            manager.Undo();

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 2, 3);
        }

        [Fact]
        public void UnDoSet_IntersectWith_Should_()
        {
            IUnDoManager manager = new UnDoManager();
            ISet<int> unDoSet = new HashSet<int> { 1, 2, 3 }.AsUnDo(manager);

            unDoSet.IntersectWith(new[] { 2 });

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(2);

            manager.Undo();

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 2, 3);
        }

        [Fact]
        public void UnDoSet_IsProperSubsetOf_Should_call_IsProperSubsetOf()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.IsProperSubsetOf(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.IsProperSubsetOf(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_IsProperSupersetOf_Should_call_IsProperSupersetOf()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.IsProperSupersetOf(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.IsProperSupersetOf(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_IsSubsetOf_Should_call_IsSubsetOf()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.IsSubsetOf(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.IsSubsetOf(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_IsSupersetOf_Should_call_IsSupersetOf()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.IsSupersetOf(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.IsSupersetOf(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_Overlaps_Should_call_Overlaps()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.Overlaps(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.Overlaps(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_SetEquals_Should_call_SetEquals()
        {
            ISet<int> source = Substitute.For<ISet<int>>();
            IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
            IUnDoManager manager = Substitute.For<IUnDoManager>();
            ISet<int> unDoSet = source.AsUnDo(manager);
            bool done = false;

            source.When(s => s.SetEquals(other)).Do(_ => done = true);
            manager.Do(Arg.Do<IUnDo>(i => i.Do()));

            unDoSet.SetEquals(other);

            Check.That(done).IsTrue();
        }

        [Fact]
        public void UnDoSet_SymmetricExceptWith_Should_()
        {
            IUnDoManager manager = new UnDoManager();
            ISet<int> unDoSet = new HashSet<int> { 1, 2, 3 }.AsUnDo(manager);

            unDoSet.SymmetricExceptWith(new[] { 2, 3, 4 });

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 4);

            manager.Undo();

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 2, 3);
        }

        [Fact]
        public void UnDoSet_UnionWith_Should_()
        {
            IUnDoManager manager = new UnDoManager();
            ISet<int> unDoSet = new HashSet<int> { 1, 2, 3 }.AsUnDo(manager);

            unDoSet.UnionWith(new[] { 2, 3, 4 });

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 2, 3, 4);

            manager.Undo();

            Check.That(unDoSet.OrderBy(i => i)).ContainsExactly(1, 2, 3);
        }

        #endregion
    }
}
