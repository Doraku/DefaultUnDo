using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests.TransactionTests;

public sealed class DisposeShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Fact]
    public void ThrowWhenNotTheLatestTransaction()
    {
        IUnDoManager manager = new UnDoManager(1);

        IUnDoTransaction transaction1 = manager.BeginTransaction();
        IUnDoTransaction transaction2 = manager.BeginTransaction();

        Check.ThatCode(transaction1.Dispose).Throws<InvalidOperationException>();
    }

    [Fact]
    public void NotUndoWhenCommitted()
    {
        IUnDoManager manager = new UnDoManager(1);

        bool unDone = false;

        using (IUnDoTransaction transaction = manager.BeginTransaction())
        {
            IUnDo undo = Substitute.For<IUnDo>();
            undo.When(u => u.Undo()).Do(_ => unDone = true);

            manager.Do(undo);

            transaction.Commit();
        }

        Check.That(unDone).IsFalse();
    }

    [Fact]
    public void UndoWhenNotCommitted()
    {
        IUnDoManager manager = new UnDoManager(1);

        bool unDone = false;

        using (IUnDoTransaction transaction = manager.BeginTransaction())
        {
            IUnDo undo = Substitute.For<IUnDo>();
            undo.When(u => u.Undo()).Do(_ => unDone = true);

            manager.Do(undo);
        }

        Check.That(unDone).IsTrue();
    }
}
