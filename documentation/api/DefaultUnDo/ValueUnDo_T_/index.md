#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## ValueUnDo\<T\> Class

Provides an implementation of the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') interface for setting value\.

```csharp
public sealed class ValueUnDo<T> : DefaultUnDo.IMergeableUnDo, DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.ValueUnDo_T_.T'></a>

`T`

The type of value\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; ValueUnDo<T>

Implements [IMergeableUnDo](../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo'), [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

| Constructors | |
| :--- | :--- |
| [ValueUnDo\(object, Action&lt;T&gt;, T, T\)](ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T) 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(object, System\.Action\<T\>, T, T\)') | Initialises an instance of [ValueUnDo&lt;T&gt;](DefaultUnDo/ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>')\. |
| [ValueUnDo\(Action&lt;T&gt;, T, T\)](ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T) 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(System\.Action\<T\>, T, T\)') | Initialises an instance of [ValueUnDo&lt;T&gt;](DefaultUnDo/ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>')\. |

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](MergeDescriptionAction.md 'DefaultUnDo\.ValueUnDo\<T\>\.MergeDescriptionAction') | The [MergeDescriptionHandler\(object, T, object, T\)](MergeDescriptionHandler(object,T,object,T)/index.md 'DefaultUnDo\.ValueUnDo\<T\>\.MergeDescriptionHandler\(object, T, object, T\)') used to merge description between two [ValueUnDo&lt;T&gt;](DefaultUnDo/ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') instance\. |
| [MergeInterval](MergeInterval.md 'DefaultUnDo\.ValueUnDo\<T\>\.MergeInterval') | The [System\.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System\.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](DefaultUnDo/ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') instances should respect to be mergeable\. If not set, [MergeInterval](../ValueUnDo/MergeInterval.md 'DefaultUnDo\.ValueUnDo\.MergeInterval') will be used\. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo\.IMergeableUnDo\.TryMerge\(IUnDo, IUnDo\)](DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo,IUnDo).md 'DefaultUnDo\.ValueUnDo\<T\>\.DefaultUnDo\.IMergeableUnDo\.TryMerge\(DefaultUnDo\.IUnDo, DefaultUnDo\.IUnDo\)') | Merges the current instance with the specified [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\. |
| [DefaultUnDo\.IUnDo\.Description](DefaultUnDo.IUnDo.Description.md 'DefaultUnDo\.ValueUnDo\<T\>\.DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') perform\. |
| [DefaultUnDo\.IUnDo\.Do\(\)](DefaultUnDo.IUnDo.Do().md 'DefaultUnDo\.ValueUnDo\<T\>\.DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [DefaultUnDo\.IUnDo\.Undo\(\)](DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo\.ValueUnDo\<T\>\.DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
