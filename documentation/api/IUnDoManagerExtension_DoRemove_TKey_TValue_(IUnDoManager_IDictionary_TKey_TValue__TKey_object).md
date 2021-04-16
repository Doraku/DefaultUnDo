#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, object) Method
Removes the item with the specified key from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static bool DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_TKey'></a>
`TKey`  
The type of the key.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_TValue'></a>
`TValue`  
The type of the value.
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_TValue 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_key'></a>
`key` [TKey](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TKey')  
The key to remove.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).source') did not contained [key](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).key').
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).manager'), [source](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).source') or [key](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md#DefaultUnDo_IUnDoManagerExtension_DoRemove_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_object)_key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).key') is null.
