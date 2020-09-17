### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[DictionaryUnDo&lt;TKey,TValue&gt;](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;')
## DictionaryUnDo(string, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool) Constructor
Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;').  
```csharp
public DictionaryUnDo(string description, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of this [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
  
<a name='DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md#DefaultUnDo-DictionaryUnDo-TKey_TValue--TKey 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md#DefaultUnDo-DictionaryUnDo-TKey_TValue--TValue 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') on which to perform operation.  
  
<a name='DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-key'></a>
`key` [TKey](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md#DefaultUnDo-DictionaryUnDo-TKey_TValue--TKey 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TKey')  
The key of the operation.  
  
<a name='DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-value'></a>
`value` [TValue](./DefaultUnDo-DictionaryUnDo-TKey_TValue-.md#DefaultUnDo-DictionaryUnDo-TKey_TValue--TValue 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TValue')  
The value of the operation.  
  
<a name='DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is [System.Collections.Generic.IDictionary&lt;&gt;.Add(@0,@1)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Add#System_Collections_Generic_IDictionary_2_Add__0,_1_ 'System.Collections.Generic.IDictionary`2.Add(`0,`1)'), false for [System.Collections.Generic.IDictionary&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Remove#System_Collections_Generic_IDictionary_2_Remove__0_ 'System.Collections.Generic.IDictionary`2.Remove(`0)').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-source 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(string, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool).source') or [key](#DefaultUnDo-DictionaryUnDo-TKey_TValue--DictionaryUnDo(string_System-Collections-Generic-IDictionary-TKey_TValue-_TKey_TValue_bool)-key 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(string, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool).key') is null.  
