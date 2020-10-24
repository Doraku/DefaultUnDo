using System.Collections.Generic;

namespace DefaultUnDo
{
    /// <summary>
    /// Describes the action that is performed on an <see cref="ICollection{T}"/> and recorded by an <see cref="IUnDoManager"/>./>
    /// </summary>
    public enum UnDoCollectionAction
    {
        /// <summary>
        /// <see cref="ICollection{T}.Add(T)"/> was performed.
        /// </summary>
        ICollectionAdd,
        /// <summary>
        /// <see cref="ICollection{T}.Remove(T)"/> was performed.
        /// </summary>
        ICollectionRemove,
        /// <summary>
        /// <see cref="ICollection{T}.Clear"/> was performed.
        /// </summary>
        ICollectionClear,

        /// <summary>
        /// <see cref="ISet{T}.Add(T)"/> was performed.
        /// </summary>
        ISetAdd,
        /// <summary>
        /// <see cref="ISet{T}.ExceptWith(IEnumerable{T})"/> was performed.
        /// </summary>
        ISetExceptWith,
        /// <summary>
        /// <see cref="ISet{T}.IntersectWith(IEnumerable{T})"/> was performed.
        /// </summary>
        ISetIntersectWith,
        /// <summary>
        /// <see cref="ISet{T}.SymmetricExceptWith(IEnumerable{T})"/> was performed.
        /// </summary>
        ISetSymmetricExceptWith,
        /// <summary>
        /// <see cref="ISet{T}.UnionWith(IEnumerable{T})"/> was performed.
        /// </summary>
        ISetUnionWith,

        /// <summary>
        /// <see cref="IListExtension.Move{T}(IList{T}, int, int)"/> was performed.
        /// </summary>
        IListMove,
        /// <summary>
        /// <see cref="IList{T}.Insert(int, T)"/> was performed.
        /// </summary>
        IListInsert,
        /// <summary>
        /// <see cref="IList{T}.RemoveAt(int)"/> was performed.
        /// </summary>
        IListRemoveAt,
        /// <summary>
        /// <see cref="P:System.Collections.Generic.IList`1.Item(``0)"/> was performed.
        /// </summary>
        IList_this,

        /// <summary>
        /// <see cref="IDictionary{TKey, TValue}.Add(TKey, TValue)"/> was performed.
        /// </summary>
        IDictionaryAdd,
        /// <summary>
        /// <see cref="IDictionary{TKey, TValue}.Remove(TKey)"/> was performed.
        /// </summary>
        IDictionaryRemove,
        /// <summary>
        /// <see cref="P:System.Collections.Generic.IDictionary`2.Item(``0)"/> was performed.
        /// </summary>
        IDictionary_this
    }
}
