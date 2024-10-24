#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## DictionaryUnDo\<TKey,TValue\> Class

Provides an implementation of the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') interface for [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') operation\.

```csharp
public sealed class DictionaryUnDo<TKey,TValue> : DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.TKey'></a>

`TKey`

Type of the keys\.

<a name='DefaultUnDo.DictionaryUnDo_TKey,TValue_.TValue'></a>

`TValue`

Type of the values\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; DictionaryUnDo<TKey,TValue>

Implements [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

| Constructors | |
| :--- | :--- |
| [DictionaryUnDo\(object, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool\)](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(object,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool) 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>\.DictionaryUnDo\(object, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, bool\)') | Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DefaultUnDo/DictionaryUnDo_TKey,TValue_/index.md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>')\. |
| [DictionaryUnDo\(IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool\)](DictionaryUnDo_TKey,TValue_.md#DefaultUnDo.DictionaryUnDo_TKey,TValue_.DictionaryUnDo(System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,bool) 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>\.DictionaryUnDo\(System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, bool\)') | Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DefaultUnDo/DictionaryUnDo_TKey,TValue_/index.md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>')\. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo\.IUnDo\.Description](DefaultUnDo.IUnDo.Description.md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>\.DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') perform\. |
| [DefaultUnDo\.IUnDo\.Do\(\)](DefaultUnDo.IUnDo.Do().md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>\.DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [DefaultUnDo\.IUnDo\.Undo\(\)](DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>\.DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
