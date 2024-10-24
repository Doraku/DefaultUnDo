using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoManagerTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentExceptionWhenMaxCapacityIsInferiorOrEqualToZero()
    {
        Check.ThatCode(() => new UnDoManager(-1)).Throws<ArgumentException>();
    }
}
