using NFluent;
using Xunit;

namespace DefaultUnDo;

public sealed class UnDoTest
{
    [Fact]
    public void Do_Should_not_throw_When_doAction_is_null()
    {
        IUnDo undo = new UnDo(null, null);

        Check
            .ThatCode(undo.Do)
            .DoesNotThrow();
    }

    [Fact]
    public void Undo_Should_not_throw_When_undoAction_is_null()
    {
        IUnDo undo = new UnDo(null, null);

        Check
            .ThatCode(undo.Undo)
            .DoesNotThrow();
    }

    [Fact]
    public void Do_Should_do_doAction()
    {
        bool done = false;
        IUnDo undo = new UnDo(() => done = true, null);

        undo.Do();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void Undo_Should_do_undoAction()
    {
        bool done = false;
        IUnDo undo = new UnDo(null, () => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void Description_Should_return_description()
    {
        IUnDo undo = new UnDo("test", null, null);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
