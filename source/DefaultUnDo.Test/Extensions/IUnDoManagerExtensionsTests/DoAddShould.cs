using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoAddShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForISet()
    {
        IUnDoManager manager = null;
        ISet<object> source = null;

        Check
            .ThatCode(() => manager.DoAdd(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNullForISet()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ISet<object> source = null;

        Check
            .ThatCode(() => manager.DoAdd(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForICollection()
    {
        IUnDoManager manager = null;
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoAdd(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNullForICollection()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoAdd(source, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void KeepIndexWhenSourceIsIList()
    {
        IUnDoManager manager = new UnDoManager();
        ICollection<int> source = [0, 1];

        manager.DoAdd(source, 2);

        source.Add(3);

        manager.Undo();

        Check.That(source).ContainsExactly(0, 1, 3);

        manager.Redo();

        Check.That(source).ContainsExactly(0, 1, 2, 3);
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForIDictionary()
    {
        IUnDoManager manager = null;
        IDictionary<object, object> source = null;
        object key = null;

        Check
            .ThatCode(() => manager.DoAdd(source, key, null))
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
            .ThatCode(() => manager.DoAdd(source, key, null))
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
            .ThatCode(() => manager.DoAdd(source, key, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "key");
    }
}
