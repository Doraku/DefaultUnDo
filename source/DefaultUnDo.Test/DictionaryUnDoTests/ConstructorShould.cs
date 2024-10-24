using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.DictionaryUnDoTests;

public sealed class ConstructorShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        Check
            .ThatCode(() => new DictionaryUnDo<object, object>(null, new object(), 0, false))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenKeyIsNull()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();

        Check
            .ThatCode(() => new DictionaryUnDo<object, object>(source, null, 0, false))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "key");
    }
}
