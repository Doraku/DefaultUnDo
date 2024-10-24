﻿using System.Collections.Generic;
using System.Linq;
using DefaultUnDo;
using NFluent;
using NSubstitute;
using Xunit;

namespace DefaultUnDo.Internal.UnDoISetTests;

public sealed class SymmetricExceptWithShould
{
    [Fact]
    public void Work()
    {
        IUnDoManager manager = new UnDoManager();
        ISet<int> unDoSet = new HashSet<int> { 1, 2, 3 }.AsUnDo(manager);

        unDoSet.SymmetricExceptWith([2, 3, 4]);

        Check.That(unDoSet.Order()).ContainsExactly(1, 4);

        manager.Undo();

        Check.That(unDoSet.Order()).ContainsExactly(1, 2, 3);
    }

    [Fact]
    public void GenerateSymmetricExceptWithDescription()
    {
        ISet<object> source = Substitute.For<ISet<object>>();
        IUnDoManager manager = Substitute.For<IUnDoManager>();

        UnDoCollectionOperation? description = null;

        manager.Do(Arg.Do<IUnDo>(i => i.Do()));

        ISet<object> unDoCollection = source.AsUnDo(manager, d => description = d);

        IEnumerable<object> other = [];
        unDoCollection.SymmetricExceptWith(other);

        Check.That(description.HasValue).IsTrue();
        Check.That(description.Value.Collection).IsEqualTo(unDoCollection);
        Check.That(description.Value.Action).IsEqualTo(UnDoCollectionAction.ISetSymmetricExceptWith);
        Check.That(description.Value.Parameters.Length).IsEqualTo(1);
        Check.That(description.Value.Parameters[0]).IsEqualTo(other);
    }
}