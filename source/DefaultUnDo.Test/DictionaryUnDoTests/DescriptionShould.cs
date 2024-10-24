using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.DictionaryUnDoTests;

public sealed class DescriptionShould
{
    [Fact]
    public void ReturnDescription()
    {
        object key = new();
        IUnDo undo = new DictionaryUnDo<object, object>("test", Substitute.For<IDictionary<object, object>>(), key, null, true);

        Check.That(undo.Description).IsEqualTo("test");
    }
}
