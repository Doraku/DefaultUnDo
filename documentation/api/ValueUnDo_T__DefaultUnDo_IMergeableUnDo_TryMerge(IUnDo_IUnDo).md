#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')
## ValueUnDo&lt;T&gt;.DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo, IUnDo) Method
Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').  
```csharp
bool DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo other, out DefaultUnDo.IUnDo mergedCommand);
```
#### Parameters
<a name='DefaultUnDo_ValueUnDo_T__DefaultUnDo_IMergeableUnDo_TryMerge(DefaultUnDo_IUnDo_DefaultUnDo_IUnDo)_other'></a>
`other` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The other [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance the current one should try to merge with.
  
<a name='DefaultUnDo_ValueUnDo_T__DefaultUnDo_IMergeableUnDo_TryMerge(DefaultUnDo_IUnDo_DefaultUnDo_IUnDo)_mergedCommand'></a>
`mergedCommand` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The resulting merged [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance if the operation was successful.
  

Implements [TryMerge(IUnDo, IUnDo)](IMergeableUnDo_TryMerge(IUnDo_IUnDo).md 'DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)')  
