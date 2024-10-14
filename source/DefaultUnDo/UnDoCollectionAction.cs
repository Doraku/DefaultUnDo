using System.Collections.Generic;

namespace DefaultUnDo;

/// <summary>
/// Describes the action that will be performed on an <see cref="ICollection{T}"/> and recorded by an <see cref="IUnDoManager"/>.
/// </summary>
public enum UnDoCollectionAction
{
    /// <summary>
    /// <see cref="ICollection{T}.Add(T)"/> will be performed.
    /// </summary>
    ICollectionAdd,
    /// <summary>
    /// <see cref="ICollection{T}.Remove(T)"/> will be performed.
    /// </summary>
    ICollectionRemove,
    /// <summary>
    /// <see cref="ICollection{T}.Clear"/> will be performed.
    /// </summary>
    ICollectionClear,

    /// <summary>
    /// <see cref="ISet{T}.Add(T)"/> will be performed.
    /// </summary>
    ISetAdd,
    /// <summary>
    /// <see cref="ISet{T}.ExceptWith(IEnumerable{T})"/> will be performed.
    /// </summary>
    ISetExceptWith,
    /// <summary>
    /// <see cref="ISet{T}.IntersectWith(IEnumerable{T})"/> will be performed.
    /// </summary>
    ISetIntersectWith,
    /// <summary>
    /// <see cref="ISet{T}.SymmetricExceptWith(IEnumerable{T})"/> will be performed.
    /// </summary>
    ISetSymmetricExceptWith,
    /// <summary>
    /// <see cref="ISet{T}.UnionWith(IEnumerable{T})"/> will be performed.
    /// </summary>
    ISetUnionWith,

    /// <summary>
    /// <see cref="IListExtension.Move{T}(IList{T}, int, int)"/> will be performed.
    /// </summary>
    IListMove,
    /// <summary>
    /// <see cref="IList{T}.Insert(int, T)"/> will be performed.
    /// </summary>
    IListInsert,
    /// <summary>
    /// <see cref="IList{T}.RemoveAt(int)"/> will be performed.
    /// </summary>
    IListRemoveAt,
    /// <summary>
    /// <see cref="P:System.Collections.Generic.IList`1.Item(System.Int32)"/> will be performed.
    /// </summary>
    IListIndexer,

    /// <summary>
    /// <see cref="IDictionary{TKey, TValue}.Add(TKey, TValue)"/> will be performed.
    /// </summary>
    IDictionaryAdd,
    /// <summary>
    /// <see cref="IDictionary{TKey, TValue}.Remove(TKey)"/> will be performed.
    /// </summary>
    IDictionaryRemove,
    /// <summary>
    /// <see cref="P:System.Collections.Generic.IDictionary`2.Item(``0)"/> will be performed.
    /// </summary>
    IDictionaryIndexer
}
