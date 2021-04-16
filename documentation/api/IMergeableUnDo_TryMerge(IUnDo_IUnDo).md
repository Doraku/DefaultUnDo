#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo')
## IMergeableUnDo.TryMerge(IUnDo, IUnDo) Method
Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').  
```csharp
bool TryMerge(DefaultUnDo.IUnDo other, out DefaultUnDo.IUnDo mergedCommand);
```
#### Parameters
<a name='DefaultUnDo_IMergeableUnDo_TryMerge(DefaultUnDo_IUnDo_DefaultUnDo_IUnDo)_other'></a>
`other` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The other [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance the current one should try to merge with.
  
<a name='DefaultUnDo_IMergeableUnDo_TryMerge(DefaultUnDo_IUnDo_DefaultUnDo_IUnDo)_mergedCommand'></a>
`mergedCommand` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The resulting merged [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance if the operation was successful.
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the merge was successful; otherwise false.
