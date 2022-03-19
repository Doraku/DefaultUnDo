#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## UnDoCollectionAction Enum

Describes the action that will be performed on an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') and recorded by an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

```csharp
public enum UnDoCollectionAction
```
### Fields

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionAdd'></a>

`ICollectionAdd` 0

[System.Collections.Generic.ICollection&lt;&gt;.Add(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Add#System_Collections_Generic_ICollection_1_Add__0_ 'System.Collections.Generic.ICollection`1.Add(`0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionClear'></a>

`ICollectionClear` 2

[System.Collections.Generic.ICollection&lt;&gt;.Clear](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Clear 'System.Collections.Generic.ICollection`1.Clear') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionRemove'></a>

`ICollectionRemove` 1

[System.Collections.Generic.ICollection&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryAdd'></a>

`IDictionaryAdd` 12

[System.Collections.Generic.IDictionary&lt;&gt;.Add(@0,@1)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Add#System_Collections_Generic_IDictionary_2_Add__0,_1_ 'System.Collections.Generic.IDictionary`2.Add(`0,`1)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryIndexer'></a>

`IDictionaryIndexer` 14

[System.Collections.Generic.IDictionary&lt;&gt;.Item(@@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Item#System_Collections_Generic_IDictionary_2_Item___0_ 'System.Collections.Generic.IDictionary`2.Item(``0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryRemove'></a>

`IDictionaryRemove` 13

[System.Collections.Generic.IDictionary&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Remove#System_Collections_Generic_IDictionary_2_Remove__0_ 'System.Collections.Generic.IDictionary`2.Remove(`0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IListIndexer'></a>

`IListIndexer` 11

[System.Collections.Generic.IList&lt;&gt;.Item(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.Item#System_Collections_Generic_IList_1_Item_System_Int32_ 'System.Collections.Generic.IList`1.Item(System.Int32)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IListInsert'></a>

`IListInsert` 9

[System.Collections.Generic.IList&lt;&gt;.Insert(System.Int32,@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.Insert#System_Collections_Generic_IList_1_Insert_System_Int32,_0_ 'System.Collections.Generic.IList`1.Insert(System.Int32,`0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IListMove'></a>

`IListMove` 8

[Move&lt;T&gt;(this IList&lt;T&gt;, int, int)](IListExtension.Move_T_(thisIList_T_,int,int).md 'DefaultUnDo.IListExtension.Move<T>(this System.Collections.Generic.IList<T>, int, int)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.IListRemoveAt'></a>

`IListRemoveAt` 10

[System.Collections.Generic.IList&lt;&gt;.RemoveAt(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System.Collections.Generic.IList`1.RemoveAt(System.Int32)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ISetAdd'></a>

`ISetAdd` 3

[System.Collections.Generic.ISet&lt;&gt;.Add(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.Add#System_Collections_Generic_ISet_1_Add__0_ 'System.Collections.Generic.ISet`1.Add(`0)') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ISetExceptWith'></a>

`ISetExceptWith` 4

[System.Collections.Generic.ISet&lt;&gt;.ExceptWith(System.Collections.Generic.IEnumerable{@0})](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.ExceptWith#System_Collections_Generic_ISet_1_ExceptWith_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.ExceptWith(System.Collections.Generic.IEnumerable{`0})') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ISetIntersectWith'></a>

`ISetIntersectWith` 5

[System.Collections.Generic.ISet&lt;&gt;.IntersectWith(System.Collections.Generic.IEnumerable{@0})](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.IntersectWith#System_Collections_Generic_ISet_1_IntersectWith_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.IntersectWith(System.Collections.Generic.IEnumerable{`0})') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ISetSymmetricExceptWith'></a>

`ISetSymmetricExceptWith` 6

[System.Collections.Generic.ISet&lt;&gt;.SymmetricExceptWith(System.Collections.Generic.IEnumerable{@0})](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.SymmetricExceptWith#System_Collections_Generic_ISet_1_SymmetricExceptWith_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.SymmetricExceptWith(System.Collections.Generic.IEnumerable{`0})') will be performed.

<a name='DefaultUnDo.UnDoCollectionAction.ISetUnionWith'></a>

`ISetUnionWith` 7

[System.Collections.Generic.ISet&lt;&gt;.UnionWith(System.Collections.Generic.IEnumerable{@0})](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1.UnionWith#System_Collections_Generic_ISet_1_UnionWith_System_Collections_Generic_IEnumerable{_0}_ 'System.Collections.Generic.ISet`1.UnionWith(System.Collections.Generic.IEnumerable{`0})') will be performed.