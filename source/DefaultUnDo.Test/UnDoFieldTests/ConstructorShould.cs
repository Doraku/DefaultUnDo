using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.UnDoFieldTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        Check
            .ThatCode(() => new UnDoField<object>(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }
}
