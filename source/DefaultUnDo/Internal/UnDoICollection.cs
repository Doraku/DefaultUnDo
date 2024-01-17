using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DefaultUnDo.Internal
{
    internal class UnDoICollection<T> : ICollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private readonly ICollection<T> _source;

        protected readonly IUnDoManager _manager;
        protected readonly Func<UnDoCollectionOperation, object?>? _descriptionFactory;

        public UnDoICollection(IUnDoManager manager, ICollection<T> source, Func<UnDoCollectionOperation, object?>? descriptionFactory)
        {
            _source = source;
            _manager = manager;
            _descriptionFactory = descriptionFactory;
        }

        #region ICollection

        void ICollection<T>.Add(T item) => _manager.DoAdd(_source, item, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ICollectionAdd, item)));

        void ICollection<T>.Clear() => _manager.DoClear(_source, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ICollectionClear)));

        bool ICollection<T>.Contains(T item) => _source.Contains(item);

        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => _source.CopyTo(array, arrayIndex);

        int ICollection<T>.Count => _source.Count;

        bool ICollection<T>.IsReadOnly => _source.IsReadOnly;

        bool ICollection<T>.Remove(T item) => _manager.DoRemove(_source, item, _descriptionFactory?.Invoke(new UnDoCollectionOperation(this, UnDoCollectionAction.ICollectionRemove, item)));

        #endregion

        #region IEnumerator

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_source).GetEnumerator();

        #endregion

        #region INotifyCollectionChanged

        event NotifyCollectionChangedEventHandler? INotifyCollectionChanged.CollectionChanged
        {
            add
            {
                if (_source is INotifyCollectionChanged collection)
                {
                    collection.CollectionChanged += value;
                }
            }
            remove
            {
                if (_source is INotifyCollectionChanged collection)
                {
                    collection.CollectionChanged -= value;
                }
            }
        }

        #endregion

        #region INotifyPropertyChanged

        event PropertyChangedEventHandler? INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                if (_source is INotifyPropertyChanged collection)
                {
                    collection.PropertyChanged += value;
                }
            }
            remove
            {
                if (_source is INotifyPropertyChanged collection)
                {
                    collection.PropertyChanged -= value;
                }
            }
        }

        #endregion
    }
}
