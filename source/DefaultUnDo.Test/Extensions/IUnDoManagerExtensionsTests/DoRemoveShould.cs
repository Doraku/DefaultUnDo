using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoRemoveShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForICollection()
    {
        IUnDoManager manager = null;
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoRemove(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNullForICollection()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoRemove(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void KeepIndexWhenSourceIsIList()
    {
        IUnDoManager manager = new UnDoManager();
        ICollection<int> source = [0, 1];

        manager.DoRemove(source, 0);

        manager.Undo();

        Check.That(source).ContainsExactly(0, 1);
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForIDictionary()
    {
        IUnDoManager manager = null;
        IDictionary<object, object> source = null;
        object key = null;

        Check
            .ThatCode(() => manager.DoRemove(source, key))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNullForIDictionary()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IDictionary<object, object> source = null;
        object key = null;

        Check
            .ThatCode(() => manager.DoRemove(source, key))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenKeyIsNull()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        object key = null;

        Check
            .ThatCode(() => manager.DoRemove(source, key))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "key");
    }
}
