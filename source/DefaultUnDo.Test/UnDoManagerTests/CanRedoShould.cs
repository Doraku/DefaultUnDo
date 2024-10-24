using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class CanRedoShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnFalseWhenNoCommandHasBeenDone(IUnDoManager manager)
    {
        Check.That(manager.CanRedo).IsFalse();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnTrueWhenACommandHasBeenUndone(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();

        Check.That(manager.CanRedo).IsTrue();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnFalseWhenAllCommandsHaveBeenRedone(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();
        manager.Redo();

        Check.That(manager.CanRedo).IsFalse();
    }
}
