using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class VersionShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void IncrementeWhenACommandIsDone(IUnDoManager manager)
    {
        int oldVersion = manager.Version;

        manager.Do(Substitute.For<IUnDo>());

        Check.That(manager.Version).IsStrictlyGreaterThan(oldVersion);
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnOldValueWhenACommandIsUndone(IUnDoManager manager)
    {
        int oldVersion = manager.Version;

        manager.Do(Substitute.For<IUnDo>());
        manager.Undo();

        Check.That(manager.Version).IsEqualTo(oldVersion);
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnLastValueWhenACommandIsRedone(IUnDoManager manager)
    {
        manager.Do(Substitute.For<IUnDo>());

        int lastVersion = manager.Version;

        manager.Undo();
        manager.Redo();

        Check.That(manager.Version).IsEqualTo(lastVersion);
    }
}
