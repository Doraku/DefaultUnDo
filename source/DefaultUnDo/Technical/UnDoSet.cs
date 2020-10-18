using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo.Technical
{
    internal class UnDoSet<T> : UnDoCollection<T>, ISet<T>
    {
        #region Fields

        private readonly ISet<T> _source;

        #endregion

        #region Initialisation

        public UnDoSet(IUnDoManager manager, ISet<T> source, Func<string, object> descriptionFactory)
            : base(manager, source, descriptionFactory)
        {
            _source = source;
        }

        #endregion

        #region ISet

        bool ISet<T>.Add(T item) => _manager.DoAdd(_source, item, _descriptionFactory?.Invoke(nameof(ISet<T>.Add)));

        void ISet<T>.ExceptWith(IEnumerable<T> other)
        {
            if (_source.Count > 0)
            {
                using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.ExceptWith))))
                {
                    foreach (T item in other)
                    {
                        _manager.DoRemove(_source, item);
                    }
                }
            }
        }

        void ISet<T>.IntersectWith(IEnumerable<T> other)
        {
            if (_source.Count > 0)
            {
                List<T> items = other.Where(_source.Contains).ToList();

                using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.IntersectWith))))
                {
                    _manager.DoClear(_source);
                    foreach (T item in items)
                    {
                        _manager.DoAdd(_source, item);
                    }
                }
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
            using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.SymmetricExceptWith))))
            {
                foreach (T item in other)
                {
                    if (!_manager.DoRemove(_source, item))
                    {
                        _manager.DoAdd(_source, item);
                    }
                }
            }
        }

        void ISet<T>.UnionWith(IEnumerable<T> other)
        {
            using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(ISet<T>.UnionWith))))
            {
                foreach (T item in other)
                {
                    _manager.DoAdd(_source, item);
                }
            }
        }

        #endregion
    }
}
