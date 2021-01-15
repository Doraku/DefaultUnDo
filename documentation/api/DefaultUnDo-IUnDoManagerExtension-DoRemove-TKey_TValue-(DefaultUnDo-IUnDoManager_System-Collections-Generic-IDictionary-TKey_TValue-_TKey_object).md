### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object) Method
Removes the item with the specified key from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static bool DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-TKey'></a>
`TKey`  
The type of the key.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-TValue'></a>
`TValue`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-TValue 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-key'></a>
`key` [TKey](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).TKey')  
The key to remove.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).source') did not contained [key](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).key').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-manager 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).manager'), [source](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).source') or [key](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_object)-key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object).key') is null.  
