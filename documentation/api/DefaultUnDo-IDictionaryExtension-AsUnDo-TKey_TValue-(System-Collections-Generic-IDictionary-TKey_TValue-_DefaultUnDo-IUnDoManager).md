### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IDictionaryExtension](./DefaultUnDo-IDictionaryExtension.md 'DefaultUnDo.IDictionaryExtension')
## IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager) Method
Wraps an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.IDictionary<TKey,TValue> AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, DefaultUnDo.IUnDoManager manager);
```
#### Type parameters
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TKey'></a>
`TKey`  
The type of keys.  
  
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TValue'></a>
`TValue`  
The type of values.  
  
#### Parameters
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A wrapped [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-source 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).source') or [manager](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager)-manager 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager).manager') is null.  
