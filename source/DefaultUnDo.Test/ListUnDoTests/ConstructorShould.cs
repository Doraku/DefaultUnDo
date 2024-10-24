using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.ListUnDoTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        Check
            .ThatCode(() => new ListUnDo<object>(null, 0, null, false))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }
}
