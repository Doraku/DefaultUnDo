#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## IListExtension Class
Provides a method to wrap an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class IListExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IListExtension  
### Methods

***
[AsUnDo&lt;T&gt;(IList&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](IListExtension_AsUnDo_T_(IList_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')

Wraps an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[Move&lt;T&gt;(IList&lt;T&gt;, int, int)](IListExtension_Move_T_(IList_T__int_int).md 'DefaultUnDo.IListExtension.Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int)')

Moves the item at the specified index to a new location in the collection.  
If [source](IListExtension_Move_T_(IList_T__int_int).md#DefaultUnDo_IListExtension_Move_T_(System_Collections_Generic_IList_T__int_int)_source 'DefaultUnDo.IListExtension.Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int).source') is an UnDo list and its inner source an [System.Collections.ObjectModel.ObservableCollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1'), it will use the [System.Collections.ObjectModel.ObservableCollection&lt;&gt;.Move(System.Int32,System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1.Move#System_Collections_ObjectModel_ObservableCollection_1_Move_System_Int32,System_Int32_ 'System.Collections.ObjectModel.ObservableCollection`1.Move(System.Int32,System.Int32)') method;  
else it will do an [System.Collections.Generic.IList&lt;&gt;.RemoveAt(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System.Collections.Generic.IList`1.RemoveAt(System.Int32)') and [System.Collections.Generic.IList&lt;&gt;.Insert(System.Int32,@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.Insert#System_Collections_Generic_IList_1_Insert_System_Int32,_0_ 'System.Collections.Generic.IList`1.Insert(System.Int32,`0)').  