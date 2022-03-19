#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## ValueUnDo<T> Class

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for setting value.

```csharp
public sealed class ValueUnDo<T> :
DefaultUnDo.IMergeableUnDo,
DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.ValueUnDo_T_.T'></a>

`T`

The type of value.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueUnDo<T>

Implements [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo'), [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

| Constructors | |
| :--- | :--- |
| [ValueUnDo(object, Action&lt;T&gt;, T, T)](ValueUnDo_T_.ValueUnDo(object,Action_T_,T,T).md 'DefaultUnDo.ValueUnDo<T>.ValueUnDo(object, System.Action<T>, T, T)') | Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>'). |
| [ValueUnDo(Action&lt;T&gt;, T, T)](ValueUnDo_T_.ValueUnDo(Action_T_,T,T).md 'DefaultUnDo.ValueUnDo<T>.ValueUnDo(System.Action<T>, T, T)') | Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>'). |

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](ValueUnDo_T_.MergeDescriptionAction.md 'DefaultUnDo.ValueUnDo<T>.MergeDescriptionAction') | The [MergeDescriptionHandler(object, T, object, T)](ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).md 'DefaultUnDo.ValueUnDo<T>.MergeDescriptionHandler(object, T, object, T)') used to merge description between two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') instance. |
| [MergeInterval](ValueUnDo_T_.MergeInterval.md 'DefaultUnDo.ValueUnDo<T>.MergeInterval') | The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') instances should respect to be mergeable.<br/>If not set, [MergeInterval](ValueUnDo.MergeInterval.md 'DefaultUnDo.ValueUnDo.MergeInterval') will be used. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo, IUnDo)](ValueUnDo_T_.DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo,IUnDo).md 'DefaultUnDo.ValueUnDo<T>.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)') | Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo'). |
| [DefaultUnDo.IUnDo.Description](ValueUnDo_T_.DefaultUnDo.IUnDo.Description.md 'DefaultUnDo.ValueUnDo<T>.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform. |
| [DefaultUnDo.IUnDo.Do()](ValueUnDo_T_.DefaultUnDo.IUnDo.Do().md 'DefaultUnDo.ValueUnDo<T>.DefaultUnDo.IUnDo.Do()') | Does an action. |
| [DefaultUnDo.IUnDo.Undo()](ValueUnDo_T_.DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo.ValueUnDo<T>.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()') action. |
