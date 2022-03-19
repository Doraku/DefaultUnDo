#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## IUnDo Interface

Provides methods to execute an action and remove its effect.

```csharp
public interface IUnDo
```

Derived  
&#8627; [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo<T>')  
&#8627; [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey,TValue_.md 'DefaultUnDo.DictionaryUnDo<TKey,TValue>')  
&#8627; [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')  
&#8627; [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo')  
&#8627; [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo<T>')  
&#8627; [UnDo](UnDo.md 'DefaultUnDo.UnDo')  
&#8627; [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>')

| Properties | |
| :--- | :--- |
| [Description](IUnDo.Description.md 'DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform. |

| Methods | |
| :--- | :--- |
| [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()') | Does an action. |
| [Undo()](IUnDo.Undo().md 'DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()') action. |
