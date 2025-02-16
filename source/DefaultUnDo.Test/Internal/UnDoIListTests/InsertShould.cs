﻿using System.Collections.Generic;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoIListTests;

public sealed class InsertShould
{
    [Fact]
    public void Insert()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();
        const int index = 42;
        object value = new();

        bool done = false;

        source.When(s => s.Insert(index, value)).Do(_ => done = true);
        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoList = source.AsUnDo(manager);

        unDoList.Insert(index, value);

        Check.That(done).IsTrue();
    }

    [Fact]
    public void GenerateInsertDescription()
    {
        IList<object> source = Substitute.For<IList<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        IList<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        const int index = 42;
        object item = new();
        unDoCollection.Insert(index, item);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.IListInsert);
        Check.That(description.Value.Parameters.Length).IsEqualTo(2);
        Check.That(description.Value.Parameters[0]).IsEqualTo(index);
        Check.That(description.Value.Parameters[1]).IsEqualTo(item);
    }
}
