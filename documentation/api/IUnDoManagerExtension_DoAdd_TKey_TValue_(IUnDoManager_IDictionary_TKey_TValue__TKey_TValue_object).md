#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object) Method
Adds a value to a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TKey'></a>
`TKey`  
The type of the key.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TValue'></a>
`TValue`  
The type of the value.
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_key'></a>
`key` [TKey](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TKey')  
The key to add.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_value'></a>
`value` [TValue](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TValue')  
The value to add.
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).manager'), [source](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).source') or [key](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md#DefaultUnDo_IUnDoManagerExtension_DoAdd_TKey_TValue_(DefaultUnDo_IUnDoManager_System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_object)_key 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).key') is null.
