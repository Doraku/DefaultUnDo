### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string) Method
Adds a value to a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, string description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TKey'></a>
`TKey`  
The type of the key.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TValue'></a>
`TValue`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-key'></a>
`key` [TKey](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).TKey')  
The key to add.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-value'></a>
`value` [TValue](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).TValue')  
The value to add.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).manager'), [source](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).source') or [key](#DefaultUnDo-IUnDoManagerExtension-DoAdd-TKey_TValue-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_string)-key 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, string).key') is null.  
