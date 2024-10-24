using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoISetTests;

public sealed class OverlapsShould
{
    [Fact]
    public void CallOverlaps()
    {
        ISet<int> source = Substitute.For<ISet<int>>();
        IEnumerable<int> other = Substitute.For<IEnumerable<int>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ISet<int> unDoSet = source.AsUnDo(manager);
        bool done = false;

        source.When(s => s.Overlaps(other)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        unDoSet.Overlaps(other);

        Check.That(done).IsTrue();
    }
}
