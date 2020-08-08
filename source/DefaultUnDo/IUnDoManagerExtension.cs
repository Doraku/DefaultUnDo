using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultUnDo
{
    /// <summary>
    /// Provides methods to create <see cref="IUnDo"/> command and add them to an <see cref="IUnDoManager"/>.
    /// </summary>
    public static class IUnDoManagerExtension
    {
        #region Methods

        /// <summary>
        /// Adds an item from a <see cref="ISet{T}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ISet{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="ISet{T}"/>.</param>
        /// <param name="item">The item to add.</param>
        /// <returns>true if the command has been created, false if not because <paramref name="source"/> already contained <paramref name="item"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static bool DoAdd<T>(this IUnDoManager manager, ISet<T> source, T item)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            bool result = !source.Contains(item);

            if (result)
            {
                manager.Do(new CollectionUnDo<T>(source, item, true));
            }

            return result;
        }

        /// <summary>
        /// Adds a value to a <see cref="ICollection{T}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="ICollection{T}"/>.</param>
        /// <param name="item">The item to add.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static void DoAdd<T>(this IUnDoManager manager, ICollection<T> source, T item)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (source is IList<T> list)
            {
                manager.DoInsert(list, list.Count, item);
            }
            else
            {
                manager.Do(new CollectionUnDo<T>(source, item, true));
            }
        }

        /// <summary>
        /// Clears a <see cref="ICollection{T}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="ICollection{T}"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static void DoClear<T>(this IUnDoManager manager, ICollection<T> source)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            T[] oldValues = source.ToArray();

            manager.Do(source.Clear, () => { foreach (T oldValue in oldValues) { source.Add(oldValue); } });
        }

        /// <summary>
        /// Removes an item from a <see cref="ICollection{T}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="ICollection{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="ICollection{T}"/>.</param>
        /// <param name="item">The item to remove.</param>
        /// <returns>true if the command has been created, false if not because <paramref name="source"/> did not contained <paramref name="item"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static bool DoRemove<T>(this IUnDoManager manager, ICollection<T> source, T item)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            bool result = false;

            if (source is IList<T> list)
            {
                int index = list.IndexOf(item);
                if (index >= 0)
                {
                    manager.DoRemoveAt(list, index);
                    result = true;
                }
            }
            else if (source.Contains(item))
            {
                manager.Do(new CollectionUnDo<T>(source, item, false));
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Adds a value to a <see cref="IDictionary{TKey, TValue}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/>.</param>
        /// <param name="key">The key to add.</param>
        /// <param name="value">The value to add.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/>, <paramref name="source"/> or <paramref name="key"/> is null.</exception>
        public static void DoAdd<TKey, TValue>(this IUnDoManager manager, IDictionary<TKey, TValue> source, TKey key, TValue value)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            manager.Do(new DictionaryUnDo<TKey, TValue>(source, key, value, true));
        }

        /// <summary>
        /// Removes the item with the specified key from a <see cref="IDictionary{TKey, TValue}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/>.</param>
        /// <param name="key">The key to remove.</param>
        /// <returns>true if the command has been created, false if not because <paramref name="source"/> did not contained <paramref name="key"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/>, <paramref name="source"/> or <paramref name="key"/> is null.</exception>
        public static bool DoRemove<TKey, TValue>(this IUnDoManager manager, IDictionary<TKey, TValue> source, TKey key)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            bool result = false;
            if (source.TryGetValue(key, out TValue value))
            {
                manager.Do(new DictionaryUnDo<TKey, TValue>(source, key, value, false));
                result = true;
            }

            return result;
        }

        /// <summary>
        /// Sets the element with the specified key on a <see cref="IDictionary{TKey, TValue}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="TKey">The type of the key.</typeparam>
        /// <typeparam name="TValue">The type of the value.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IDictionary{TKey, TValue}"/>.</param>
        /// <param name="key">The key to set.</param>
        /// <param name="value">The value to add.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/>, <paramref name="source"/> or <paramref name="key"/> is null.</exception>
        public static void Do<TKey, TValue>(this IUnDoManager manager, IDictionary<TKey, TValue> source, TKey key, TValue value)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }
            if (key is null)
            {
                throw new ArgumentNullException(nameof(key));
            }

            if (source.TryGetValue(key, out TValue oldValue))
            {
                manager.Do(v => source[key] = v, value, oldValue);
            }
            else
            {
                manager.Do(() => source[key] = value, () => source.Remove(key));
            }
        }

        /// <summary>
        /// Inserts an item to a <see cref="IList{T}"/> at the specified index as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IList{T}"/>.</param>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The item to insert into the <see cref="IList{T}"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static void DoInsert<T>(this IUnDoManager manager, IList<T> source, int index, T item)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            manager.Do(new ListUnDo<T>(source, index, item, true));
        }

        /// <summary>
        /// Removes an item from a <see cref="IList{T}"/> at the specified index as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IList{T}"/>.</param>
        /// <param name="index">The zero-based index at which item should be removed.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static void DoRemoveAt<T>(this IUnDoManager manager, IList<T> source, int index)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            manager.Do(new ListUnDo<T>(source, index, source[index], false));
        }

        /// <summary>
        /// Sets the element at the specified index on a <see cref="IList{T}"/> as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of element in the <see cref="IList{T}"/>.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="source">The <see cref="IList{T}"/>.</param>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <param name="item">The new item.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="source"/> is null.</exception>
        public static void Do<T>(this IUnDoManager manager, IList<T> source, int index, T item)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            manager.Do(v => source[index] = v, item, source[index]);
        }

        /// <summary>
        /// Does a <see cref="IUnDo"/> operation on the manager with the specified doAction and undoAction.
        /// </summary>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="doAction">The <see cref="Action"/> performed by <see cref="IUnDo.Do"/>.</param>
        /// <param name="undoAction">The <see cref="Action"/> performed by the <see cref="IUnDo.Undo"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> is null.</exception>
        public static void Do(this IUnDoManager manager, Action doAction, Action undoAction)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }

            manager.Do(new UnDo(doAction, undoAction));
        }

        /// <summary>
        /// Does a <see cref="IUnDo"/> operation on the manager with the specified action with no undo.
        /// </summary>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="action">The <see cref="Action"/> performed by <see cref="IUnDo.Do"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> is null.</exception>
        public static void DoOnDo(this IUnDoManager manager, Action action) => manager.Do(action, null);

        /// <summary>
        /// Does a <see cref="IUnDo"/> operation on the manager with the specified action with no do.
        /// </summary>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="action">The <see cref="Action"/> performed by <see cref="IUnDo.Undo"/>.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> is null.</exception>
        public static void DoOnUndo(this IUnDoManager manager, Action action) => manager.Do(null, action);

        /// <summary>
        /// Sets a value as a <see cref="IUnDo"/> operation.
        /// </summary>
        /// <typeparam name="T">The type of the value.</typeparam>
        /// <param name="manager">The <see cref="IUnDoManager"/>.</param>
        /// <param name="setter">The <see cref="Action{T}"/> used to change the value.</param>
        /// <param name="newValue">The new value.</param>
        /// <param name="oldValue">The old value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="manager"/> or <paramref name="setter"/> is null.</exception>
        public static void Do<T>(this IUnDoManager manager, Action<T> setter, T newValue, T oldValue)
        {
            if (manager is null)
            {
                throw new ArgumentNullException(nameof(manager));
            }
            if (setter is null)
            {
                throw new ArgumentNullException(nameof(setter));
            }

            manager.Do(new ValueUnDo<T>(setter, newValue, oldValue));
        }

        #endregion
    }
}
