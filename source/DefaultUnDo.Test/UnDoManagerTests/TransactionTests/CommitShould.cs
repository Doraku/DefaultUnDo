using System;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests.TransactionTests;

public sealed class CommitShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void AddCommandsAsOneOperationInHistory(IUnDoManager manager)
    {
        IUnDo undo = Substitute.For<IUnDo>();
        undo.Description.Returns("dummy");
        int version = manager.Version;

        using (IUnDoTransaction t1 = manager.BeginTransaction("first"))
        using (IUnDoTransaction t2 = manager.BeginTransaction("second"))
        {
            manager.Do(undo);
            manager.Do(undo);

            t2.Commit();
            t1.Commit();
        }

        Check.That(manager.Version).IsStrictlyGreaterThan(version);
        Check.That(manager.UndoDescriptions).ContainsExactly("first");

        manager.Undo();

        Check.That(manager.Version).IsEqualTo(version);
    }

    [Fact]
    public void ThrowWhenAlreadyDisposed()
    {
        IUnDoManager manager = new UnDoManager(1);

        IUnDoTransaction transaction = manager.BeginTransaction();

        transaction.Dispose();

        Check.ThatCode(transaction.Commit).Throws<ObjectDisposedException>();
    }

    [Fact]
    public void ThrowWhenAlreadyCommitted()
    {
        IUnDoManager manager = new UnDoManager(1);

        IUnDoTransaction transaction = manager.BeginTransaction();

        transaction.Commit();

        Check.ThatCode(transaction.Commit).Throws<InvalidOperationException>();
    }

    [Fact]
    public void ThrowWhenNotTheLatestTransaction()
    {
        IUnDoManager manager = new UnDoManager(1);

        IUnDoTransaction transaction1 = manager.BeginTransaction();
        IUnDoTransaction transaction2 = manager.BeginTransaction();

        Check.ThatCode(transaction1.Commit).Throws<InvalidOperationException>();
    }
}
