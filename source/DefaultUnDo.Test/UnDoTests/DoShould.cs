using DefaultUnDo;
using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoTests;

public sealed class DoShould
{
    [Fact]
    public void NotThrowWhenDoActionIsNull()
    {
        IUnDo undo = new UnDo(null, null);

        Check
            .ThatCode(undo.Do)
            .DoesNotThrow();
    }

    [Fact]
    public void DoDoAction()
    {
        bool done = false;
        IUnDo undo = new UnDo(() => done = true, null);

        undo.Do();

        Check.That(done).IsTrue();
    }
}
