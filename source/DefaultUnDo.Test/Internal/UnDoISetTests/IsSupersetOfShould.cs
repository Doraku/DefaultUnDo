using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoISetTests;

public sealed class IsSupersetOfShould
{
    [Fact]
    public void CallIsSupersetOf()
    {
        ISet<int> source = Substitute.For<ISet<int>>();
        IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ISet<int> unDoSet = source.AsUnDo(manager);
        bool done = false;

        source.When(s => s.IsSupersetOf(other)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        unDoSet.IsSupersetOf(other);

        Check.That(done).IsTrue();
    }
}
