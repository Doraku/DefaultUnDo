#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey,TValue_.md 'DefaultUnDo.DictionaryUnDo<TKey,TValue>')

## DictionaryUnDo(IDictionary<TKey,TValue>, TKey, TValue, bool) Constructor

Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey,TValue_.md 'DefaultUnDo.DictionaryUnDo<TKey,TValue>').

```csharp
public DictionaryUnDo(System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).source'></a>

`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.TKey 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.TValue 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') on which to perform operation.

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).key'></a>

`key` [TKey](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.TKey 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.TKey')

The key of the operation.

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).value'></a>

`value` [TValue](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.TValue 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.TValue')

The value of the operation.

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).isAdd'></a>

`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true if the operation is [System.Collections.Generic.IDictionary&lt;&gt;.Add(@0,@1)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Add#System_Collections_Generic_IDictionary_2_Add__0,_1_ 'System.Collections.Generic.IDictionary`2.Add(`0,`1)'), false for [System.Collections.Generic.IDictionary&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2.Remove#System_Collections_Generic_IDictionary_2_Remove__0_ 'System.Collections.Generic.IDictionary`2.Remove(`0)').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](DictionaryUnDo_TKey,TValue_.DictionaryUnDo(IDictionary_TKey,TValue_,TKey,TValue,bool).md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).source 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.DictionaryUnDo(System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, bool).source') or [key](DictionaryUnDo_TKey,TValue_.DictionaryUnDo(IDictionary_TKey,TValue_,TKey,TValue,bool).md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool).key 'DefaultUnDo.DictionaryUnDo<TKey,TValue>.DictionaryUnDo(System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, bool).key') is null.