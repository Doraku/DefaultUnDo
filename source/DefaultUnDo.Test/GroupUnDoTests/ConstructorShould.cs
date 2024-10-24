using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.GroupUnDoTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenCommandsIsNull()
    {
        Check
            .ThatCode(() => new GroupUnDo(default))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "commands");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenCommandsEmpty()
    {
        Check
            .ThatCode(() => new GroupUnDo())
            .Throws<ArgumentException>()
            .WithProperty("ParamName", "commands");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenCommandsContainsNull()
    {
        Check
            .ThatCode(() => new GroupUnDo([null]))
            .Throws<ArgumentException>()
            .WithProperty("ParamName", "commands");
    }
}
