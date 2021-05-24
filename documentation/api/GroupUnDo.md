#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## GroupUnDo Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for a group of operations.  
```csharp
public sealed class GroupUnDo :
DefaultUnDo.IMergeableUnDo,
DefaultUnDo.IUnDo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GroupUnDo  

Implements [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo'), [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  

| Constructors | |
| :--- | :--- |
| [GroupUnDo(IUnDo[])](GroupUnDo_GroupUnDo(IUnDo__).md 'DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[])') | Initialise an instance of [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo').<br/> |
| [GroupUnDo(object, IUnDo[])](GroupUnDo_GroupUnDo(object_IUnDo__).md 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[])') | Initialise an instance of [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo').<br/> |

| Methods | |
| :--- | :--- |
| [TryGetSingle&lt;T&gt;(T)](GroupUnDo_TryGetSingle_T_(T).md 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T)') | Gets the single [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T') of this instance.<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo, IUnDo)](GroupUnDo_DefaultUnDo_IMergeableUnDo_TryMerge(IUnDo_IUnDo).md 'DefaultUnDo.GroupUnDo.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)') | Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').<br/> |
| [DefaultUnDo.IUnDo.Description](GroupUnDo_DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.GroupUnDo.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.<br/> |
| [DefaultUnDo.IUnDo.Do()](GroupUnDo_DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.GroupUnDo.DefaultUnDo.IUnDo.Do()') | Does an action.<br/> |
| [DefaultUnDo.IUnDo.Undo()](GroupUnDo_DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.GroupUnDo.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.<br/> |
