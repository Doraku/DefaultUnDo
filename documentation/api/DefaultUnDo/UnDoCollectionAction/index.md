#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## UnDoCollectionAction Enum

Describes the action that will be performed on an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') and recorded by an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

```csharp
public enum UnDoCollectionAction
```
### Fields

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionAdd'></a>

`ICollectionAdd` 0

[System\.Collections\.Generic\.ICollection&lt;&gt;\.Add\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.add#system-collections-generic-icollection-1-add(-0) 'System\.Collections\.Generic\.ICollection\`1\.Add\(\`0\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionRemove'></a>

`ICollectionRemove` 1

[System\.Collections\.Generic\.ICollection&lt;&gt;\.Remove\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.remove#system-collections-generic-icollection-1-remove(-0) 'System\.Collections\.Generic\.ICollection\`1\.Remove\(\`0\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ICollectionClear'></a>

`ICollectionClear` 2

[System\.Collections\.Generic\.ICollection&lt;&gt;\.Clear](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.clear 'System\.Collections\.Generic\.ICollection\`1\.Clear') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ISetAdd'></a>

`ISetAdd` 3

[System\.Collections\.Generic\.ISet&lt;&gt;\.Add\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1.add#system-collections-generic-iset-1-add(-0) 'System\.Collections\.Generic\.ISet\`1\.Add\(\`0\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ISetExceptWith'></a>

`ISetExceptWith` 4

[System\.Collections\.Generic\.ISet&lt;&gt;\.ExceptWith\(System\.Collections\.Generic\.IEnumerable\{@0\}\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1.exceptwith#system-collections-generic-iset-1-exceptwith(system-collections-generic-ienumerable{-0}) 'System\.Collections\.Generic\.ISet\`1\.ExceptWith\(System\.Collections\.Generic\.IEnumerable\{\`0\}\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ISetIntersectWith'></a>

`ISetIntersectWith` 5

[System\.Collections\.Generic\.ISet&lt;&gt;\.IntersectWith\(System\.Collections\.Generic\.IEnumerable\{@0\}\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1.intersectwith#system-collections-generic-iset-1-intersectwith(system-collections-generic-ienumerable{-0}) 'System\.Collections\.Generic\.ISet\`1\.IntersectWith\(System\.Collections\.Generic\.IEnumerable\{\`0\}\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ISetSymmetricExceptWith'></a>

`ISetSymmetricExceptWith` 6

[System\.Collections\.Generic\.ISet&lt;&gt;\.SymmetricExceptWith\(System\.Collections\.Generic\.IEnumerable\{@0\}\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1.symmetricexceptwith#system-collections-generic-iset-1-symmetricexceptwith(system-collections-generic-ienumerable{-0}) 'System\.Collections\.Generic\.ISet\`1\.SymmetricExceptWith\(System\.Collections\.Generic\.IEnumerable\{\`0\}\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.ISetUnionWith'></a>

`ISetUnionWith` 7

[System\.Collections\.Generic\.ISet&lt;&gt;\.UnionWith\(System\.Collections\.Generic\.IEnumerable\{@0\}\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1.unionwith#system-collections-generic-iset-1-unionwith(system-collections-generic-ienumerable{-0}) 'System\.Collections\.Generic\.ISet\`1\.UnionWith\(System\.Collections\.Generic\.IEnumerable\{\`0\}\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IListMove'></a>

`IListMove` 8

[Move&lt;T&gt;\(this IList&lt;T&gt;, int, int\)](../IListExtensions/Move_T_(thisIList_T_,int,int).md 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IListInsert'></a>

`IListInsert` 9

[System\.Collections\.Generic\.IList&lt;&gt;\.Insert\(System\.Int32,@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.insert#system-collections-generic-ilist-1-insert(system-int32--0) 'System\.Collections\.Generic\.IList\`1\.Insert\(System\.Int32,\`0\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IListRemoveAt'></a>

`IListRemoveAt` 10

[System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.removeat#system-collections-generic-ilist-1-removeat(system-int32) 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IListIndexer'></a>

`IListIndexer` 11

[System\.Collections\.Generic\.IList&lt;&gt;\.Item\(System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.item#system-collections-generic-ilist-1-item(system-int32) 'System\.Collections\.Generic\.IList\`1\.Item\(System\.Int32\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryAdd'></a>

`IDictionaryAdd` 12

[System\.Collections\.Generic\.IDictionary&lt;&gt;\.Add\(@0,@1\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2.add#system-collections-generic-idictionary-2-add(-0--1) 'System\.Collections\.Generic\.IDictionary\`2\.Add\(\`0,\`1\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryRemove'></a>

`IDictionaryRemove` 13

[System\.Collections\.Generic\.IDictionary&lt;&gt;\.Remove\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2.remove#system-collections-generic-idictionary-2-remove(-0) 'System\.Collections\.Generic\.IDictionary\`2\.Remove\(\`0\)') will be performed\.

<a name='DefaultUnDo.UnDoCollectionAction.IDictionaryIndexer'></a>

`IDictionaryIndexer` 14

[System\.Collections\.Generic\.IDictionary&lt;&gt;\.Item\(@@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2.item#system-collections-generic-idictionary-2-item(--0) 'System\.Collections\.Generic\.IDictionary\`2\.Item\(\`\`0\)') will be performed\.