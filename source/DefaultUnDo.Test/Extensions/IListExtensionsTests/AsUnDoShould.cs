using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Extensions.IListExtensionsTests;

public sealed class IListExtensionTest
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        IList<int> source = null;

        Check
            .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        IList<int> source = Substitute.For<IList<int>>();

        Check
            .ThatCode(() => source.AsUnDo(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }
}
