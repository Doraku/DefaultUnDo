using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using Xunit;

namespace DefaultUnDo.Extensions.IUnDoManagerExtensionsTests;

public sealed class DoClearShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        IUnDoManager manager = null;
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoClear(source))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ICollection<object> source = null;

        Check
            .ThatCode(() => manager.DoClear(source))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void AddOldElementsWhenUndone()
    {
        ICollection<object> source = [
            new(),
            new(),
            new()
        ];
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        IUnDo undo = null;
        List<object> sourceCopy = [.. source];

        manager.Do(Arg.Do<IUnDo>(i => undo = i));

        manager.DoClear(source);

        Check.That(undo).IsNotNull();

        undo.Do();

        Check.That(source.Count).IsEqualTo(0);

        undo.Undo();

        Check.That(source).ContainsExactly(sourceCopy);
    }
}
