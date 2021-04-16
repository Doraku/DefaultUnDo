#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoRemoveAt&lt;T&gt;(IUnDoManager, IList&lt;T&gt;, int, object) Method
Removes an item from a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') at the specified index as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoRemoveAt<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](IUnDoManagerExtension_DoRemoveAt_T_(IUnDoManager_IList_T__int_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_T 'DefaultUnDo.IUnDoManagerExtension.DoRemoveAt&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index at which item should be removed.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoRemoveAt_T_(IUnDoManager_IList_T__int_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoRemoveAt&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, object).manager') or [source](IUnDoManagerExtension_DoRemoveAt_T_(IUnDoManager_IList_T__int_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemoveAt_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoRemoveAt&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, object).source') is null.
