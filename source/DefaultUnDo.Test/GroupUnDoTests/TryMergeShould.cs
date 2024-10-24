using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.GroupUnDoTests;

public sealed class TryMergeShould
{
    [Fact]
    public void ReturnFalseWhenGroupIsNotSingleIMergeableUnDo()
    {
        IMergeableUnDo group = new GroupUnDo("test", Substitute.For<IUnDo>());
        IUnDo undo = Substitute.For<IUnDo>();
        undo.Description.Returns("test");

        Check.That(group.TryMerge(undo, out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenSingleIMergeableUnDoDoNotMerge()
    {
        IUnDo undo = Substitute.For<IUnDo>();
        IMergeableUnDo group = new GroupUnDo("test", Substitute.For<IMergeableUnDo>());
        undo.Description.Returns("test");

        Check.That(group.TryMerge(undo, out _)).IsFalse();
    }

    [Fact]
    public void ReturnTrueWhenMerged()
    {
        IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
        IUnDo undo = Substitute.For<IUnDo>();
        IMergeableUnDo group = new GroupUnDo("test", mergeable);
        undo.Description.Returns("test");
        mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
        {
            x[1] = undo;
            return true;
        });

        Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo(group.Description);

        IUnDo newUndo = null;
        (merged as GroupUnDo)?.TryGetSingle(out newUndo);

        Check.That(newUndo).IsEqualTo(undo);
    }

    [Fact]
    public void UseGroupDescription()
    {
        IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
        IUnDo undo = Substitute.For<IUnDo>();
        IMergeableUnDo group = new GroupUnDo("test", mergeable);
        undo.Description.Returns("test1");
        mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
        {
            x[1] = undo;
            return true;
        });
        Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo(group.Description);
    }

    [Fact]
    public void UseMergeDescriptionActionWhenSet()
    {
        IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
        IUnDo undo = Substitute.For<IUnDo>();
        IMergeableUnDo group = new GroupUnDo("test", mergeable);
        undo.Description.Returns("test");
        mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
        {
            x[1] = undo;
            return true;
        });
        GroupUnDo.MergeDescriptionAction = (_, _, _) => "kikoo";

        Check.That(group.TryMerge(undo, out IUnDo merged)).IsTrue();
        Check.That(merged.Description).IsEqualTo("kikoo");

        GroupUnDo.MergeDescriptionAction = null;
    }
}
