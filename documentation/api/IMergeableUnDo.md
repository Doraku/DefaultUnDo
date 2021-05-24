#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## IMergeableUnDo Interface
Provides a method to try to merge two [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instances into a single one.  
```csharp
public interface IMergeableUnDo :
DefaultUnDo.IUnDo
```

Derived  
&#8627; [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')  
&#8627; [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')  

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  

| Methods | |
| :--- | :--- |
| [TryMerge(IUnDo, IUnDo)](IMergeableUnDo_TryMerge(IUnDo_IUnDo).md 'DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)') | Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').<br/> |
