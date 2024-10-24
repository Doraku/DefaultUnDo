using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoTests;

public sealed class UndoShould
{
    [Fact]
    public void NotThrowWhenUndoActionIsNull()
    {
        IUnDo undo = new UnDo(null, null);

        Check
            .ThatCode(undo.Undo)
            .DoesNotThrow();
    }

    [Fact]
    public void DoUndoAction()
    {
        bool done = false;
        IUnDo undo = new UnDo(null, () => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }
}
