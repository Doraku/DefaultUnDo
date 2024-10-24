using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.ValueUnDoTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSetterIsNull()
    {
        Check
            .ThatCode(() => new ValueUnDo<object>(null, null, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "setter");
    }
}
