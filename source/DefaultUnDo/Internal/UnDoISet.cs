using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo.Internal;

internal sealed class UnDoISet<T> : UnDoICollection<T>, ISet<T>
{
    private readonly ISet<T> _source;

    public UnDoISet(IUnDoManager manager, ISet<T> source, Func<UnDoCollectionOperation, object?>? descriptionFactory)
        : base(manager, source, descriptionFactory)
    {
        _source = source;
    }

    #region ISet

    bool ISet<T>.Add(T item) => _manager.DoAdd(_source, item, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ISetAdd, item)));

    void ISet<T>.ExceptWith(IEnumerable<T> other)
    {
        if (_source.Count > 0)
        {
            using IUnDoTransaction transaction = _manager.BeginTransaction(_descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ISetExceptWith, other)));

            foreach (T item in other)
            {
                _manager.DoRemove(_source, item);
            }

            transaction.Commit();
        }
    }

    void ISet<T>.IntersectWith(IEnumerable<T> other)
    {
        if (_source.Count > 0)
        {
            List<T> items = [.. other.Where(_source.Contains)];

            using IUnDoTransaction transaction = _manager.BeginTransaction(_descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ISetIntersectWith, other)));

            _manager.DoClear(_source);
            foreach (T item in items)
            {
                _manager.DoAdd(_source, item);
            }

            transaction.Commit();
        }
    }

    bool ISet<T>.IsProperSubsetOf(IEnumerable<T> other) => _source.IsProperSubsetOf(other);

    bool ISet<T>.IsProperSupersetOf(IEnumerable<T> other) => _source.IsProperSupersetOf(other);

    bool ISet<T>.IsSubsetOf(IEnumerable<T> other) => _source.IsSubsetOf(other);

    bool ISet<T>.IsSupersetOf(IEnumerable<T> other) => _source.IsSupersetOf(other);

    bool ISet<T>.Overlaps(IEnumerable<T> other) => _source.Overlaps(other);

    bool ISet<T>.SetEquals(IEnumerable<T> other) => _source.SetEquals(other);

    void ISet<T>.SymmetricExceptWith(IEnumerable<T> other)
    {
        using IUnDoTransaction transaction = _manager.BeginTransaction(_descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ISetSymmetricExceptWith, other)));

        foreach (T item in other)
        {
            if (!_manager.DoRemove(_source, item))
            {
                _manager.DoAdd(_source, item);
            }
        }

        transaction.Commit();
    }

    void ISet<T>.UnionWith(IEnumerable<T> other)
    {
        using IUnDoTransaction transaction = _manager.BeginTransaction(_descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ISetUnionWith, other)));

        foreach (T item in other)
        {
            _manager.DoAdd(_source, item);
        }

        transaction.Commit();
    }

    #endregion
}
