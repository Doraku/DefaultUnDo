using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class RedoDescriptionsShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnDescriptionsOfRedoableOperations(IUnDoManager manager)
    {
        IUnDo operation1 = Substitute.For<IUnDo>();
        IUnDo operation2 = Substitute.For<IUnDo>();

        operation1.Description.Returns("kikoo");
        operation2.Description.Returns("lol");

        manager.Do(operation1);
        manager.Do(operation2);

        Check.That(manager.RedoDescriptions).IsEmpty();

        manager.Undo();
        manager.Undo();

        Check.That(manager.RedoDescriptions).ContainsExactly("kikoo", "lol");
    }
}
