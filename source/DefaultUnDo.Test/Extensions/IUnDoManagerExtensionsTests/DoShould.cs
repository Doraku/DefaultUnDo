using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForIDictionary()
    {
        IUnDoManager manager = null;
        IDictionary<object, object> source = null;
        object key = null;

        Check
            .ThatCode(() => manager.Do(source, key, null))
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
            .ThatCode(() => manager.Do(source, key, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenKeyIsNullForIDictionary()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        object key = null;

        Check
            .ThatCode(() => manager.Do(source, key, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "key");
    }

    [Fact]
    public void RemoveElementWhenUndoneForIDictionary()
    {
        object key = new();
        IDictionary<object, object> source = new Dictionary<object, object>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IUnDo undo = null;

        manager.Do(Arg.Do<IUnDo>(i => undo = i));

        manager.Do(source, key, null);

        Check.That(undo).IsNotNull();

        undo.Do();

        Check.That(source.ContainsKey(key)).IsTrue();

        undo.Undo();

        Check.That(source.ContainsKey(key)).IsFalse();
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForIList()
    {
        IUnDoManager manager = null;
        IList<object> source = null;

        Check
            .ThatCode(() => manager.Do(source, 0, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNullForIList()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IList<object> source = null;

        Check
            .ThatCode(() => manager.Do(source, 0, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForAction()
    {
        IUnDoManager manager = null;
        Action doAction = null;
        Action undoAction = null;

        Check
            .ThatCode(() => manager.Do(doAction, undoAction))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void NotDoAnythingWhenBothActionsAreNullForAction()
    {
        IUnDoManager manager = new UnDoManager();
        Action doAction = null;
        Action undoAction = null;

        manager.Do(doAction, undoAction);

        Check.That(manager.CanUndo).IsFalse();
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNullForSetter()
    {
        IUnDoManager manager = null;
        Action<object> setter = null;

        Check
            .ThatCode(() => manager.Do(setter, null, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSetterIsNullForSetter()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        Action<object> setter = null;

        Check
            .ThatCode(() => manager.Do(setter, null, null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "setter");
    }
}
