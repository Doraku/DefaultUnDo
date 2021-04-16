#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoClear&lt;T&gt;(IUnDoManager, ICollection&lt;T&gt;, object) Method
Clears a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoClear<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](IUnDoManagerExtension_DoClear_T_(IUnDoManager_ICollection_T__object).md#DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_T 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoClear_T_(IUnDoManager_ICollection_T__object).md#DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).manager') or [source](IUnDoManagerExtension_DoClear_T_(IUnDoManager_ICollection_T__object).md#DefaultUnDo_IUnDoManagerExtension_DoClear_T_(DefaultUnDo_IUnDoManager_System_Collections_Generic_ICollection_T__object)_source 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).source') is null.
