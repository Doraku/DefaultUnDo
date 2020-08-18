### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## IMergeableUnDo Interface
Provides a method to try to merge two [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') instances into a single one.  
```csharp
public interface IMergeableUnDo :
IUnDo
```
Derived  
&#8627; [GroupUnDo](./DefaultUnDo-GroupUnDo.md 'DefaultUnDo.GroupUnDo')  
&#8627; [ValueUnDo&lt;T&gt;](./DefaultUnDo-ValueUnDo-T-.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')  

Implements [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
### Methods
- [TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)](./DefaultUnDo-IMergeableUnDo-TryMerge(DefaultUnDo-IUnDo_DefaultUnDo-IUnDo).md 'DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)')
