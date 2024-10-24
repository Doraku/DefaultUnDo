using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.UnDoFieldTests;

public sealed class ImplicitOperatorShould
{
    [Fact]
    public void ReturnValue()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        const int value = 42;
        int currentValue = new UnDoField<int>(manager, value);

        Check.That(currentValue).IsEqualTo(value);
    }

    [Fact]
    public void ReturnDefaultWhenNull()
    {
        Check.That<int>(default).IsEqualTo((int)default(UnDoField<int>));
    }
}
