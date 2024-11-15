#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## GroupUnDo Class

Provides an implementation of the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') interface for a group of operations\.

```csharp
public sealed class GroupUnDo : DefaultUnDo.IMergeableUnDo, DefaultUnDo.IUnDo
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; GroupUnDo

Implements [IMergeableUnDo](../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo'), [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

| Constructors | |
| :--- | :--- |
| [GroupUnDo\(object, scoped ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |
| [GroupUnDo\(scoped ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](MergeDescriptionAction.md 'DefaultUnDo\.GroupUnDo\.MergeDescriptionAction') | The [MergeDescriptionHandler\(object, object, object\)](MergeDescriptionHandler(object,object,object)/index.md 'DefaultUnDo\.GroupUnDo\.MergeDescriptionHandler\(object, object, object\)') used to merge description between a [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo') and a [IMergeableUnDo](../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo') instances\. |

| Methods | |
| :--- | :--- |
| [TryGetSingle&lt;T&gt;\(T\)](TryGetSingle_T_(T).md 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)') | Gets the single [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T') of this instance\. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo\.IMergeableUnDo\.TryMerge\(IUnDo, IUnDo\)](DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo,IUnDo).md 'DefaultUnDo\.GroupUnDo\.DefaultUnDo\.IMergeableUnDo\.TryMerge\(DefaultUnDo\.IUnDo, DefaultUnDo\.IUnDo\)') | Merges the current instance with the specified [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\. |
| [DefaultUnDo\.IUnDo\.Description](DefaultUnDo.IUnDo.Description.md 'DefaultUnDo\.GroupUnDo\.DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') perform\. |
| [DefaultUnDo\.IUnDo\.Do\(\)](DefaultUnDo.IUnDo.Do().md 'DefaultUnDo\.GroupUnDo\.DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [DefaultUnDo\.IUnDo\.Undo\(\)](DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo\.GroupUnDo\.DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
