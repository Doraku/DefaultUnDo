using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoInsertShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        IUnDoManager manager = null;
        IList<object> source = null;

        Check
            .ThatCode(() => manager.DoInsert(source, 0, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IList<object> source = null;

        Check
            .ThatCode(() => manager.DoInsert(source, 0, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }
}
