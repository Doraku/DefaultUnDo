#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;T&gt;(IUnDoManager, IList&lt;T&gt;, int, T, object) Method
Sets the element at the specified index on a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](IUnDoManagerExtension_Do_T_(IUnDoManager_IList_T__int_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the element to get or set.
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_item'></a>
`item` [T](IUnDoManagerExtension_Do_T_(IUnDoManager_IList_T__int_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).T')  
The new item.
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_Do_T_(IUnDoManager_IList_T__int_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).manager') or [source](IUnDoManagerExtension_Do_T_(IUnDoManager_IList_T__int_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IList_T__int_T_object)_source 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).source') is null.
