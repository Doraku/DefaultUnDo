### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IDictionaryExtension](./DefaultUnDo-IDictionaryExtension.md 'DefaultUnDo.IDictionaryExtension')
## IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;) Method
Wraps an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.IDictionary<TKey,TValue> AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, DefaultUnDo.IUnDoManager manager, System.Func<string,string> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TKey'></a>
`TKey`  
The type of keys.  
  
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TValue'></a>
`TValue`  
The type of values.  
  
#### Parameters
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
  
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo'), the name of the method called is passed as a parameter.  
  
#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A wrapped [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).source') or [manager](#DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).manager') is null.  
