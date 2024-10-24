using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class KeysShould
{
    [Fact]
    public void ReturnKeys()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ICollection<object> keys = Substitute.For<ICollection<object>>();

        source.Keys.Returns(keys);

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary.Keys).IsEqualTo(source.Keys);
    }
}
