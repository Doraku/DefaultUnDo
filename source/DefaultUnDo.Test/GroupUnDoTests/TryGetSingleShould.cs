using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.GroupUnDoTests;

public sealed class TryGetSingleShould
{
    [Fact]
    public void ReturnFalseWhenMultileChildren()
    {
        GroupUnDo group = new(
            Substitute.For<IUnDo>(),
            Substitute.For<IUnDo>());

        Check.That(group.TryGetSingle<IUnDo>(out _)).IsFalse();
    }

    [Fact]
    public void ReturnFalseWhenSingleChildIsNotT()
    {
        GroupUnDo group = new(Substitute.For<IUnDo>());

        Check.That(group.TryGetSingle<IMergeableUnDo>(out _)).IsFalse();
    }

    [Fact]
    public void ReturnTrueWhenSingleChildIsT()
    {
        IUnDo undo = Substitute.For<IUnDo>();
        GroupUnDo group = new(undo);

        Check.That(group.TryGetSingle(out IUnDo found)).IsTrue();
        Check.That(found).IsEqualTo(undo);
    }
}
