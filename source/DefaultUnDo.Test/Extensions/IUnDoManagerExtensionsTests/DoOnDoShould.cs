using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoOnDoShould
{
    [Fact]
    public void CallAction()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IUnDo undo = null;
        bool done = false;

        manager.Do(Arg.Do<IUnDo>(i => undo = i));
        manager.DoOnDo(() => done = true);

        Check.That(undo).IsNotNull();
        undo.Do();

        Check.That(done).IsTrue();
    }
}
