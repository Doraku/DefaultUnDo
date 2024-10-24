using System;
using NFluent;
using Xunit;

namespace DefaultUnDo.CollectionUndoTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        Check
            .ThatCode(() => new CollectionUnDo<int>(null, 0, false))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }
}
