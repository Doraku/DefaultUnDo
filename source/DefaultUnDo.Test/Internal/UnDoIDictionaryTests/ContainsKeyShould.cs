using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class ContainsKeyShould
{
    [Fact]
    public void ReturnContainsKey()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();

        source.ContainsKey(key).Returns(true);

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary.ContainsKey(key)).IsEqualTo(source.ContainsKey(key));
    }
}
