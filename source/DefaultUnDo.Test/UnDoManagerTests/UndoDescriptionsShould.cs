using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class UndoDescriptionsShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnDescriptionsOfUndoableOperations(IUnDoManager manager)
    {
        IUnDo operation1 = Substitute.For<IUnDo>();
        IUnDo operation2 = Substitute.For<IUnDo>();

        operation1.Description.Returns("kikoo");
        operation2.Description.Returns("lol");

        manager.Do(operation1);
        manager.Do(operation2);

        Check.That(manager.UndoDescriptions).ContainsExactly("lol", "kikoo");

        manager.Undo();
        manager.Undo();

        Check.That(manager.UndoDescriptions).IsEmpty();
    }
}
