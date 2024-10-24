using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class TryGetValueShould
{
    [Fact]
    public void ReturnTryGetValue()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        object key = new();
        object value = new();

        source.TryGetValue(key, out object value2).ReturnsForAnyArgs(c => { c[1] = value; return true; });

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary.TryGetValue(key, out object value1)).IsEqualTo(source.TryGetValue(key, out value2));
        Check.That(value1).IsEqualTo(value);
        Check.That(value1).IsEqualTo(value2);
    }
}
