using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoRemoveAtShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        IUnDoManager manager = null;
        IList<object> source = null;

        Check
            .ThatCode(() => manager.DoRemoveAt(source, 0))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IList<object> source = null;

        Check
            .ThatCode(() => manager.DoRemoveAt(source, 0))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }
}
