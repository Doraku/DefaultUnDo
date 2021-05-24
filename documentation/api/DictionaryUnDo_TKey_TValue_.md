#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## DictionaryUnDo&lt;TKey,TValue&gt; Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') operation.  
```csharp
public sealed class DictionaryUnDo<TKey,TValue> :
DefaultUnDo.IUnDo
```
#### Type parameters
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__TKey'></a>
`TKey`  
Type of the keys.
  
<a name='DefaultUnDo_DictionaryUnDo_TKey_TValue__TValue'></a>
`TValue`  
Type of the values.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; DictionaryUnDo&lt;TKey,TValue&gt;  

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  

| Constructors | |
| :--- | :--- |
| [DictionaryUnDo(object, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool)](DictionaryUnDo_TKey_TValue__DictionaryUnDo(object_IDictionary_TKey_TValue__TKey_TValue_bool).md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(object, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool)') | Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;').<br/> |
| [DictionaryUnDo(IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool)](DictionaryUnDo_TKey_TValue__DictionaryUnDo(IDictionary_TKey_TValue__TKey_TValue_bool).md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DictionaryUnDo(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, bool)') | Initialise an instance of [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;').<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IUnDo.Description](DictionaryUnDo_TKey_TValue__DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.<br/> |
| [DefaultUnDo.IUnDo.Do()](DictionaryUnDo_TKey_TValue__DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DefaultUnDo.IUnDo.Do()') | Does an action.<br/> |
| [DefaultUnDo.IUnDo.Undo()](DictionaryUnDo_TKey_TValue__DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.<br/> |
