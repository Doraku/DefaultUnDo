using System.Collections.Generic;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.ListUnDoTests;

public sealed class UndoShould
{
    [Fact]
    public void RemoveElementFromSourceWhenIsAddIsTrue()
    {
        const int index = 42;
        object value = new();
        IList<object> source = Substitute.For<IList<object>>();
        IUnDo undo = new ListUnDo<object>(source, index, value, true);

        bool done = false;

        source.When(s => s.RemoveAt(index)).Do(_ => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }

    [Fact]
    public void InsertElementToSourceWhenIsAddIsFalse()
    {
        const int index = 42;
        object value = new();
        IList<object> source = Substitute.For<IList<object>>();
        IUnDo undo = new ListUnDo<object>(source, index, value, false);

        bool done = false;

        source.When(s => s.Insert(index, value)).Do(_ => done = true);

        undo.Undo();

        Check.That(done).IsTrue();
    }
}
