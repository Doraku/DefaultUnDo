using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.DictionaryUnDoTests;

public sealed class DoShould
{
    [Fact]
    public void AddElementToSourceWhenIsAddIsTrue()
    {
        object key = new();
        object value = new();
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, true);

        bool done = false;

        source.When(s => s.Add(key, value)).Do(_ => done = true);

        undo.Do();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void RemoveElementFromSourceWhenIsAddIsFalse()
    {
        object key = new();
        object value = new();
        IDictionary<object, object> source = Substitute.For<IDictionary<object, object>>();
        IUnDo undo = new DictionaryUnDo<object, object>(source, key, value, false);

        bool done = false;

        source.When(s => s.Remove(key)).Do(_ => done = true);

        undo.Do();

        Check.That(done).IsTrue();
    }
}
