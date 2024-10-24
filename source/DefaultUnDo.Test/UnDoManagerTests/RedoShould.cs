using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class RedoShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowInvalidOperationExceptionWhenCanRedoIsFalse(IUnDoManager manager)
    {
        Check
            .ThatCode(manager.Redo)
            .Throws<InvalidOperationException>();
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ThrowInvalidOperationExceptionWhenATransactionIsGoingOn(IUnDoManager manager)
    {
        using (manager.BeginTransaction())
        {
            Check
                .ThatCode(manager.Redo)
                .Throws<InvalidOperationException>()
                .WithMessage("Cannot perform Redo while a transaction is going on.");
        }
    }

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void Redo(IUnDoManager manager)
    {
        IUnDo undo = Substitute.For<IUnDo>();

        manager.Do(undo);
        manager.Undo();

        bool done = false;
        undo.When(u => u.Do()).Do(_ => done = true);

        manager.Redo();

        Check.That(done).IsTrue();
    }
}
