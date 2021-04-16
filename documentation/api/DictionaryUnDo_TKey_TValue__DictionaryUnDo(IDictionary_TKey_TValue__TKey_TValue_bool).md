#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;')
## DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool) Constructor
Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;').  
```csharp
public DictionaryUnDo(System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_source'></a>
`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](DictionaryUnDo_TKey_TValue_.md#DefaultUnDo_DictionaryUnDo_TKey_TValue__TKey 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](DictionaryUnDo_TKey_TValue_.md#DefaultUnDo_DictionaryUnDo_TKey_TValue__TValue 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') on which to perform operation.
  
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_key'></a>
`key` [TKey](DictionaryUnDo_TKey_TValue_.md#DefaultUnDo_DictionaryUnDo_TKey_TValue__TKey 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TKey')  
The key of the operation.
  
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_value'></a>
`value` [TValue](DictionaryUnDo_TKey_TValue_.md#DefaultUnDo_DictionaryUnDo_TKey_TValue__TValue 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.TValue')  
The value of the operation.
  
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is [System.Collections.Generic.IDictionary&lt;&gt;.Add(@0,@1)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Add#System_Collections_Generic_IDictionary_2_Add__0,_1_ 'System.Collections.Generic.IDictionary`2.Add(`0,`1)'), false for [System.Collections.Generic.IDictionary&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Remove#System_Collections_Generic_IDictionary_2_Remove__0_ 'System.Collections.Generic.IDictionary`2.Remove(`0)').
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](DictionaryUnDo_TKey_TValue__DictionaryUnDo(IDictionary_TKey_TValue__TKey_TValue_bool).md#DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_source 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool).source') or [key](DictionaryUnDo_TKey_TValue__DictionaryUnDo(IDictionary_TKey_TValue__TKey_TValue_bool).md#DefaultUnDo_DictionaryUnDo_TKey_TValue__DictionaryUnDo(System_Collections_Generic_IDictionary_TKey_TValue__TKey_TValue_bool)_key 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool).key') is null.
