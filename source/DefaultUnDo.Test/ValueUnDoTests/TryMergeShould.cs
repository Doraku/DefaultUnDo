using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.ValueUnDoTests;

public sealed class TryMergeShould
{
    [Fact]
    public void ReturnFalseWhenOtherIsNotValueUnDo()
    {
        IMergeableUnDo value = new ValueUnDo<int>("test", _ => { }, 0, 0);
        IUnDo undo = Substitute.For<IUnDo>();
        undo.Description.Returns("test");

        Check.That(value.TryMerge(undo, out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenOtherIsNotGroupUnDoWithSingleValueUnDo()
    {
        IMergeableUnDo value = new ValueUnDo<int>("test", _ => { }, 0, 0);
        IUnDo undo = Substitute.For<IUnDo>();
        undo.Description.Returns("test");

        Check.That(value.TryMerge(new GroupUnDo("test", undo), out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenSetterAreDifferent()
    {
        IMergeableUnDo value = new ValueUnDo<int>("test", Substitute.For<Action<int>>(), 0, 0);

        Check.That(value.TryMerge(new ValueUnDo<int>("test", Substitute.For<Action<int>>(), 0, 0), out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenNewValueAndOldValueAreDifferent()
    {
        Action<int> setter = Substitute.For<Action<int>>();
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 1);

        Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 2), out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenTimestampAreTooFar()
    {
        Action<int> setter = Substitute.For<Action<int>>();
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);
        ValueUnDo<int>.MergeInterval = TimeSpan.FromSeconds(-1);

        Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out _)).IsFalse();

        ValueUnDo<int>.MergeInterval = null;
    }

    [Fact]
    public void ReturnTrueWhenMergedWithValueUnDo()
    {
        int item = 0;
        void setter(int v) => item = v;
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

        Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo(value.Description);

        merged.Do();
        Check.That(item).IsEqualTo(2);
        merged.Undo();
        Check.That(item).IsEqualTo(0);
    }

    [Fact]
    public void UseMergeDescriptionActionWhenSet()
    {
        int item = 0;
        void setter(int v) => item = v;
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);
        ValueUnDo<int>.MergeDescriptionAction = (_, _, _, _) => "kikoo";

        Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo("kikoo");

        ValueUnDo<int>.MergeDescriptionAction = null;
    }

    [Fact]
    public void UseNonGenericMergeDescriptionActionWhenSet()
    {
        int item = 0;
        void setter(int v) => item = v;
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);
        ValueUnDo.MergeDescriptionAction = (_, _) => "kikoo";

        Check.That(value.TryMerge(new ValueUnDo<int>("test", setter, 2, 1), out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo("kikoo");

        ValueUnDo.MergeDescriptionAction = null;
    }

    [Fact]
    public void UseNewDescription()
    {
        int item = 0;
        void setter(int v) => item = v;
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

        Check.That(value.TryMerge(new ValueUnDo<int>("test2", setter, 2, 1), out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo("test2");
    }

    [Fact]
    public void ReturnTrueWhenMergedWithGroupUnDo()
    {
        int item = 0;
        void setter(int v) => item = v;
        IMergeableUnDo value = new ValueUnDo<int>("test", setter, 1, 0);

        Check.That(value.TryMerge(new GroupUnDo("test", new ValueUnDo<int>("test", setter, 2, 1)), out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo(value.Description);

        merged.Do();
        Check.That(item).IsEqualTo(2);
        merged.Undo();
        Check.That(item).IsEqualTo(0);
    }
}
