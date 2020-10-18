using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DefaultUnDo.Technical
{
    internal class UnDoCollection<T> : ICollection<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        #region Fields

        private readonly ICollection<T> _source;

        protected readonly IUnDoManager _manager;
        protected readonly Func<string, object> _descriptionFactory;

        #endregion

        #region Initialisation

        public UnDoCollection(IUnDoManager manager, ICollection<T> source, Func<string, object> descriptionFactory)
        {
            _source = source;
            _manager = manager;
            _descriptionFactory = descriptionFactory;
        }

        #endregion

        #region ICollection

        void ICollection<T>.Add(T item) => _manager.DoAdd(_source, item, _descriptionFactory?.Invoke(nameof(ICollection<T>.Add)));

        void ICollection<T>.Clear() => _manager.DoClear(_source, _descriptionFactory?.Invoke(nameof(ICollection<T>.Clear)));

        bool ICollection<T>.Contains(T item) => _source.Contains(item);

        void ICollection<T>.CopyTo(T[] array, int arrayIndex) => _source.CopyTo(array, arrayIndex);

        int ICollection<T>.Count => _source.Count;

        bool ICollection<T>.IsReadOnly => _source.IsReadOnly;

        bool ICollection<T>.Remove(T item) => _manager.DoRemove(_source, item, _descriptionFactory?.Invoke(nameof(ICollection<T>.Remove)));

        #endregion

        #region IEnumerator

        IEnumerator<T> IEnumerable<T>.GetEnumerator() => _source.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_source).GetEnumerator();

        #endregion

        #region INotifyCollectionChanged

        event NotifyCollectionChangedEventHandler INotifyCollectionChanged.CollectionChanged
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

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
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
