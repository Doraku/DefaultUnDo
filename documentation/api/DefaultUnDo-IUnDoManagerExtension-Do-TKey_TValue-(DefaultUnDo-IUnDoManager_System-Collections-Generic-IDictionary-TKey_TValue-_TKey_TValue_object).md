### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object) Method
Sets the element with the specified key on a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TKey'></a>
`TKey`  
The type of the key.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TValue'></a>
`TValue`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TKey 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TValue 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-key'></a>
`key` [TKey](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TKey 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TKey')  
The key to set.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-value'></a>
`value` [TValue](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-TValue 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).TValue')  
The value to add.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).manager'), [source](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-source 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).source') or [key](#DefaultUnDo-IUnDoManagerExtension-Do-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_object)-key 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object).key') is null.  
