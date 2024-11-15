#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## IUnDo Interface

Provides methods to execute an action and remove its effect\.

```csharp
public interface IUnDo
```

Derived  
&#8627; [CollectionUnDo&lt;T&gt;](../CollectionUnDo_T_/index.md 'DefaultUnDo\.CollectionUnDo\<T\>')  
&#8627; [DictionaryUnDo&lt;TKey,TValue&gt;](../DictionaryUnDo_TKey,TValue_/index.md 'DefaultUnDo\.DictionaryUnDo\<TKey,TValue\>')  
&#8627; [GroupUnDo](../GroupUnDo/index.md 'DefaultUnDo\.GroupUnDo')  
&#8627; [IMergeableUnDo](../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo')  
&#8627; [ListUnDo&lt;T&gt;](../ListUnDo_T_/index.md 'DefaultUnDo\.ListUnDo\<T\>')  
&#8627; [UnDo](../UnDo/index.md 'DefaultUnDo\.UnDo')  
&#8627; [ValueUnDo&lt;T&gt;](../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>')

| Properties | |
| :--- | :--- |
| [Description](Description.md 'DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](index.md 'DefaultUnDo\.IUnDo') perform\. |

| Methods | |
| :--- | :--- |
| [Do\(\)](Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [Undo\(\)](Undo().md 'DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
