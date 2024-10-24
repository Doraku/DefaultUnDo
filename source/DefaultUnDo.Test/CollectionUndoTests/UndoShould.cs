using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.CollectionUndoTests;

public sealed class UndoShould
{
    [Fact]
    public void RemoveElementFromSourceWhenIsAddIsTrue()
    {
        object value = new();
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDo undo = new CollectionUnDo<object>(source, value, true);

        bool done = false;

        source.When(s => s.Remove(value)).Do(_ => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void AddElementToSourceWhenIsAddIsFalse()
    {
        object value = new();
        ICollection<object> source = Substitute.For<ICollection<object>>();
        IUnDo undo = new CollectionUnDo<object>(source, value, false);

        bool done = false;

        source.When(s => s.Add(value)).Do(_ => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }
}
