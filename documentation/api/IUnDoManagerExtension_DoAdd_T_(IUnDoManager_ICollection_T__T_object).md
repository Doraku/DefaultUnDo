#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoAdd&lt;T&gt;(IUnDoManager, ICollection&lt;T&gt;, T, object) Method
Adds a value to a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, T item, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ICollection_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_item'></a>
`item` [T](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ICollection_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object).T')  
The item to add.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ICollection_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object).manager') or [source](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ICollection_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__T_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object).source') is null.
