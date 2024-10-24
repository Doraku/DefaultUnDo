using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Extensions.ISetExtensionsTests;

public sealed class AsUnDoShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        ISet<int> source = null;

        Check
            .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        ISet<int> source = Substitute.For<ISet<int>>();

        Check
            .ThatCode(() => source.AsUnDo(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }
}
