using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class BeginTransactionShould
{
    public static TheoryData<IUnDoManager> UnDoManagers => new(new UnDoManager(), new UnDoManager(10));

    [Theory]
    [MemberData(nameof(UnDoManagers))]
    public void ReturnAnIDisposable(IUnDoManager manager)
    {
        Check.That(manager.BeginTransaction()).IsNotNull();
    }
}
