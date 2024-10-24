using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class ClearShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ClearUndoneAndDoneHistory(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());
        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();

        Check.That(manager.CanUndo).IsTrue();
        Check.That(manager.CanRedo).IsTrue();

        manager.Clear();

        Check.That(manager.CanUndo).IsFalse();
        Check.That(manager.CanRedo).IsFalse();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowWhenATransactionIsGoingOn(IUnDoManager manager)
    {
        IUnDoTransaction transaction = manager.BeginTransaction();

        Check.ThatCode(manager.Clear).Throws<InvalidOperationException>();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void CallPropertyChanged(IUnDoManager manager)
    {
        List<string> properties = [];

        manager.Do(() => { }, () => { });

        manager.PropertyChanged += (_, e) => properties.Add(e.PropertyName);

        manager.Clear();

        Check.That(properties).Contains(nameof(manager.CanUndo), nameof(manager.CanRedo), nameof(manager.UndoDescriptions), nameof(manager.RedoDescriptions));
    }
}
