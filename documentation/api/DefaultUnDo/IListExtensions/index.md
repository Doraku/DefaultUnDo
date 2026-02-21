#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## IListExtensions Class

Provides a method to wrap an [System\.Collections\.Generic\.IList&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1') to an UnDo list linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static class IListExtensions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; IListExtensions

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;T&gt;\(this IList&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;\)](AsUnDo_T_(thisIList_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo\.IListExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.IList\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)') | Wraps an [System\.Collections\.Generic\.IList&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1') to an UnDo list linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\. |
| [Move&lt;T&gt;\(this IList&lt;T&gt;, int, int\)](Move_T_(thisIList_T_,int,int).md 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)') | Moves the item at the specified index to a new location in the collection\. If [source](Move_T_(thisIList_T_,int,int).md#DefaultUnDo.IListExtensions.Move_T_(thisSystem.Collections.Generic.IList_T_,int,int).source 'DefaultUnDo\.IListExtensions\.Move\<T\>\(this System\.Collections\.Generic\.IList\<T\>, int, int\)\.source') is an UnDo list and its inner source an [System\.Collections\.ObjectModel\.ObservableCollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1 'System\.Collections\.ObjectModel\.ObservableCollection\`1'), it will use the [System\.Collections\.ObjectModel\.ObservableCollection&lt;&gt;\.Move\(System\.Int32,System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.observablecollection-1.move#system-collections-objectmodel-observablecollection-1-move(system-int32-system-int32) 'System\.Collections\.ObjectModel\.ObservableCollection\`1\.Move\(System\.Int32,System\.Int32\)') method; else it will do an [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.removeat#system-collections-generic-ilist-1-removeat(system-int32) 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)') and [System\.Collections\.Generic\.IList&lt;&gt;\.Insert\(System\.Int32,@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.insert#system-collections-generic-ilist-1-insert(system-int32--0) 'System\.Collections\.Generic\.IList\`1\.Insert\(System\.Int32,\`0\)')\. |
