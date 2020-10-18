﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DefaultUnDo.Technical
{
    internal class UnDoList<T> : UnDoCollection<T>, IList<T>
    {
        #region Fields

        private readonly IList<T> _source;

        #endregion

        #region Initialisation

        public UnDoList(IUnDoManager manager, IList<T> source, Func<string, object> descriptionFactory)
            : base(manager, source, descriptionFactory)
        {
            _source = source;
        }

        #endregion

        #region Methods

        public void Move(int oldIndex, int newIndex)
        {
            if (_source is ObservableCollection<T> collection)
            {
                _manager.Do(
                    () => collection.Move(oldIndex, newIndex),
                    () => collection.Move(newIndex, oldIndex),
                    _descriptionFactory?.Invoke(nameof(Move)));
            }
            else
            {
                using (_manager.BeginGroup(_descriptionFactory?.Invoke(nameof(Move))))
                {
                    T item = _source[oldIndex];
                    IList<T> list = this;
                    list.RemoveAt(oldIndex);
                    list.Insert(newIndex, item);
                }
            }
        }

        #endregion

        #region IList

        int IList<T>.IndexOf(T item) => _source.IndexOf(item);

        void IList<T>.Insert(int index, T item) => _manager.DoInsert(_source, index, item, _descriptionFactory?.Invoke(nameof(IList<T>.Insert)));

        void IList<T>.RemoveAt(int index) => _manager.DoRemoveAt(_source, index, _descriptionFactory?.Invoke(nameof(IList<T>.RemoveAt)));

        T IList<T>.this[int index]
        {
            get => _source[index];
            set => _manager.Do(_source, index, value, _descriptionFactory?.Invoke("this"));
        }

        #endregion
    }
}
