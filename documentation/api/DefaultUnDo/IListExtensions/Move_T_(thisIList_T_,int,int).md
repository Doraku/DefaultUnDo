#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IListExtensions](index.md 'DefaultUnDo\.IListExtensions')

## IListExtensions\.Move\<T\>\(this IList\<T\>, int, int\) Method

Moves the item at the specified index to a new location in the collection\.
If [source](Move_T_(thisIList_T_,int,int).md#DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).source 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.source') is an UnDo list and its inner source an [System\.Collections\.ObjectModel\.ObservableCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System\.Collections\.ObjectModel\.ObservableCollection\`1'), it will use the [System\.Collections\.ObjectModel\.ObservableCollection&lt;&gt;\.Move\(System\.Int32,System\.Int32\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1.Move#System_Collections_ObjectModel_ObservableCollection_1_Move_System_Int32,System_Int32_ 'System\.Collections\.ObjectModel\.ObservableCollection\`1\.Move\(System\.Int32,System\.Int32\)') method;
else it will do an [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)') and [System\.Collections\.Generic\.IList&lt;&gt;\.Insert\(System\.Int32,@0\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.Insert#System_Collections_Generic_IList_1_Insert_System_Int32,_0_ 'System\.Collections\.Generic\.IList\`1\.Insert\(System\.Int32,\`0\)')\.

```csharp
public static void Move<T>(this System.Collections.Generic.IList<T> source, int oldIndex, int newIndex);
```
#### Type parameters

<a name='DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.
#### Parameters

<a name='DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](Move_T_(thisIList_T_,int,int).md#DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).T 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') on which to perform the move\.

<a name='DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).oldIndex'></a>

`oldIndex` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The zero\-based index specifying the location of the item to be moved\.

<a name='DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).newIndex'></a>

`newIndex` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The zero\-based index specifying the new location of the item\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](Move_T_(thisIList_T_,int,int).md#DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).source 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.source') is null\.