#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IListExtension](IListExtension.md 'DefaultUnDo.IListExtension')
## IListExtension.AsUnDo&lt;T&gt;(IList&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;) Method
Wraps an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.IList<T> AsUnDo<T>(this System.Collections.Generic.IList<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
#### Parameters
<a name='DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](IListExtension_AsUnDo_T_(IList_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
<a name='DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').
  
#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](IListExtension_AsUnDo_T_(IList_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
A wrapped [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](IListExtension_AsUnDo_T_(IList_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_source 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).source') or [manager](IListExtension_AsUnDo_T_(IList_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_IListExtension_AsUnDo_T_(System_Collections_Generic_IList_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_manager 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).manager') is null.
