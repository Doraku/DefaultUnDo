### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IMergeableUnDo](./DefaultUnDo-IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo')
## IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo) Method
Merges the current instance with the specified [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo').  
```csharp
bool TryMerge(DefaultUnDo.IUnDo other, out DefaultUnDo.IUnDo mergedCommand);
```
#### Parameters
<a name='DefaultUnDo-IMergeableUnDo-TryMerge(DefaultUnDo-IUnDo_DefaultUnDo-IUnDo)-other'></a>
`other` [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
The other [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') instance the current one should try to merge with.  
  
<a name='DefaultUnDo-IMergeableUnDo-TryMerge(DefaultUnDo-IUnDo_DefaultUnDo-IUnDo)-mergedCommand'></a>
`mergedCommand` [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
The resulting merged [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') instance if the operation was successful.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the merge was successful; otherwise false.  
