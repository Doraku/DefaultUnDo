using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIDictionaryTests;

public sealed class ValuesShould
{
    [Fact]
    public void ReturnValues()
    {
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        ICollection<object> values = Substitute.For<ICollection<object>>();

        source.Values.Returns(values);

        IDictionary<object, object> unDoDictionary = source.AsUnDo(manager);

        Check.That(unDoDictionary.Values).IsEqualTo(source.Values);
    }
}
