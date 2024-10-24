using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Extensions.IDictionaryExtensionsTests;

public sealed class AsUndoShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        IDictionary<object, object> source = null;

        Check
            .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();

        Check
            .ThatCode(() => source.AsUnDo(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ReturnAnIDictionary()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        Check.That(source.AsUnDo(manager)).IsNotNull();
    }
}
