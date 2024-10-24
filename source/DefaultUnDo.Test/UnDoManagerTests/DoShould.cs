using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class DoShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowArgumentNullExceptionWhenCommandIsNull(IUnDoManager manager)
    {
        Check
            .ThatCode(() => manager.Do(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "command");
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void Do(IUnDoManager manager)
    {
        IUnDo undo = Substitute.For<IUnDo>();

        bool done = false;
        undo.When(u => u.Do()).Do(_ => done = true);

        manager.Do(undo);

        Check.That(done).IsTrue();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void MergeWhenPossible(IUnDoManager manager)
    {
        IMergeableUnDo mergeable = Substitute.For<IMergeableUnDo>();
        IUnDo undo = Substitute.For<IUnDo>();
        IUnDo merged = Substitute.For<IUnDo>();
        merged.Description.Returns("yay");

        mergeable.TryMerge(undo, out Arg.Any<IUnDo>()).Returns(x =>
        {
            x[1] = merged;
            return true;
        });

        manager.Do(mergeable);
        manager.Do(undo);

        Check.That(manager.UndoDescriptions).ContainsExactly("yay");
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void NotAddCommandInHistoryWhenAGroupIsGoingOn(IUnDoManager manager)
    {
        IUnDo undo = Substitute.For<IUnDo>();
        int version = manager.Version;

        using (manager.BeginTransaction())
        {
            manager.Do(undo);

            Check.That(manager.Version).IsEqualTo(version);
        }
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ClearUndoneHistory(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());
        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();

        Check.That(manager.CanRedo).IsTrue();

        manager.Do(Substitute.For<IUnDo>());

        Check.That(manager.CanRedo).IsFalse();
    }

    [Fact]
    public void OverrideOldestOperationWhenMaxCapacity()
    {
        IUnDoManager manager = new UnDoManager(2);

        IUnDo operation1 = Substitute.For<IUnDo>();
        IUnDo operation2 = Substitute.For<IUnDo>();
        IUnDo operation3 = Substitute.For<IUnDo>();

        operation1.Description.Returns("un");
        operation2.Description.Returns("dos");
        operation3.Description.Returns("tres");

        manager.Do(operation1);
        manager.Do(operation2);
        manager.Do(operation3);

        Check.That(manager.UndoDescriptions).ContainsExactly("tres", "dos");

        manager.Undo();
        manager.Undo();

        Check.That(manager.RedoDescriptions).ContainsExactly("dos", "tres");

        manager.Redo();
        manager.Redo();

        Check.That(manager.UndoDescriptions).ContainsExactly("tres", "dos");
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void CallPropertyChanged(IUnDoManager manager)
    {
        List<string> properties = [];
        manager.PropertyChanged += (_, e) => properties.Add(e.PropertyName);

        manager.Do(() => { }, () => { });

        Check.That(properties).Contains(nameof(manager.Version), nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));
    }
}
