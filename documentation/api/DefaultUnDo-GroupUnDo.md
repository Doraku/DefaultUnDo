### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## GroupUnDo Class
Provides an implementation of the [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') interface for a group of operations.  
```csharp
public sealed class GroupUnDo :
IMergeableUnDo,
IUnDo
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GroupUnDo  

Implements [IMergeableUnDo](./DefaultUnDo-IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo'), [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
### Constructors
- [GroupUnDo(DefaultUnDo.IUnDo[])](./DefaultUnDo-GroupUnDo-GroupUnDo(DefaultUnDo-IUnDo--).md 'DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[])')
- [GroupUnDo(object, DefaultUnDo.IUnDo[])](./DefaultUnDo-GroupUnDo-GroupUnDo(object_DefaultUnDo-IUnDo--).md 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[])')
### Methods
- [TryGetSingle&lt;T&gt;(T)](./DefaultUnDo-GroupUnDo-TryGetSingle-T-(T).md 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T)')
