### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string) Method
Removes the item with the specified key from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static bool DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, string description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-TKey'></a>
`TKey`  
The type of the key.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-TValue'></a>
`TValue`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-TValue 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-key'></a>
`key` [TKey](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).TKey')  
The key to remove.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the operation.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).source') did not contained [key](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).key').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-manager 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).manager'), [source](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-source 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).source') or [key](#DefaultUnDo-IUnDoManagerExtension-DoRemove-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_string)-key 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, string).key') is null.  
