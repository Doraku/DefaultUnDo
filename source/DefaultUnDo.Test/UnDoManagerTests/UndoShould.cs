using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class UndoShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowInvalidOperationExceptionWhenCanUndoIsFalse(IUnDoManager manager)
    {
        Check
            .ThatCode(manager.Undo)
            .Throws<InvalidOperationException>();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowInvalidOperationExceptionWhenATransactionIsGoingOn(IUnDoManager manager)
    {
        using (manager.BeginTransaction())
        {
            Check
                .ThatCode(manager.Undo)
                .Throws<InvalidOperationException>()
                .WithMessage("Cannot perform Undo while a transaction is going on.");
        }
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void Undo(IUnDoManager manager)
    {
        IUnDo undo = Substitute.For<IUnDo>();

        bool done = false;
        undo.When(u => u.Undo()).Do(_ => done = true);

        manager.Do(undo);
        manager.Undo();

        Check.That(done).IsTrue();
    }
}
