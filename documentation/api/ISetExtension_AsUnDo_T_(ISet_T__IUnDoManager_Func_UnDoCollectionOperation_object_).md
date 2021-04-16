#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ISetExtension](ISetExtension.md 'DefaultUnDo.ISetExtension')
## ISetExtension.AsUnDo&lt;T&gt;(ISet&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;) Method
Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.ISet<T> AsUnDo<T>(this System.Collections.Generic.ISet<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').
  
#### Parameters
<a name='DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](ISetExtension_AsUnDo_T_(ISet_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').
  
<a name='DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').
  
#### Returns
[System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](ISetExtension_AsUnDo_T_(ISet_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
A wrapped [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](ISetExtension_AsUnDo_T_(ISet_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_source 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).source') or [manager](ISetExtension_AsUnDo_T_(ISet_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md#DefaultUnDo_ISetExtension_AsUnDo_T_(System_Collections_Generic_ISet_T__DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoCollectionOperation_object_)_manager 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).manager') is null.
