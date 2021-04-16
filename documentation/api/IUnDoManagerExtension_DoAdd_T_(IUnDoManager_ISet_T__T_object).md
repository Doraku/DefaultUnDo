#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoAdd&lt;T&gt;(IUnDoManager, ISet&lt;T&gt;, T, object) Method
Adds an item from a [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static bool DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ISet<T> source, T item, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_item'></a>
`item` [T](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).T')  
The item to add.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).source') already contained [item](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_item 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).item').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).manager') or [source](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ISet_T__T_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).source') is null.
