using System;
using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Extensions.ICollectionExtensionsTests;

public sealed class AsUndoShould
{
    [Fact]
    public void ThrowArgumentNullExceptionWhenSourceIsNull()
    {
        ICollection<int> source = null;

        Check
            .ThatCode(() => source.AsUnDo(Substitute.For<IUnDoManager>()))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "source");
    }

    [Fact]
    public void ThrowArgumentNullExceptionWhenManagerIsNull()
    {
        ICollection<int> source = Substitute.For<ICollection<int>>();

        Check
            .ThatCode(() => source.AsUnDo(null))
            .Throws<ArgumentNullException>()
            .WithProperty("ParamName", "manager");
    }

    [Fact]
    public void ReturnAnICollection()
    {
        ICollection<int> source = Substitute.For<ICollection<int>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        Check.That(source.AsUnDo(manager)).IsNotNull();
    }
}
