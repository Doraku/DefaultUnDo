using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.GroupUnDoTests;

public sealed class DoShould
{
    [Fact]
    public void ExecuteChildrenDo()
    {
        List<IUnDo> done = [];

        IUnDo undo1 = Substitute.For<IUnDo>();
        undo1.When(u => u.Do()).Do(_ => done.Add(undo1));

        IUnDo undo2 = Substitute.For<IUnDo>();
        undo2.When(u => u.Do()).Do(_ => done.Add(undo2));

        IUnDo undo = new GroupUnDo(
            undo1,
            undo2);

        undo.Do();

        Check.That(done).ContainsExactly(undo1, undo2);
    }
}
