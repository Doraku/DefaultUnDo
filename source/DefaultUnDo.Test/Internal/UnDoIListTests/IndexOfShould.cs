using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIListTests;

public sealed class IndexOfShould
{
    [Fact]
    public void ReturnIndexOf()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object value = new();

        source.IndexOf(value).Returns(42);

        IList<object> unDoList = source.AsUnDo(manager);

        Check.That(unDoList.IndexOf(value)).IsEqualTo(source.IndexOf(value));
    }
}
