using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class CanUndoShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnFalseWhenNoCommandHasBeenDone(IUnDoManager manager)
    {
        Check.That(manager.CanUndo).IsFalse();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnTrueWhenACommandHasBeenDone(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());

        Check.That(manager.CanUndo).IsTrue();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnFalseWhenAllCommandsHaveBeenUndone(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();

        Check.That(manager.CanUndo).IsFalse();
    }
}
