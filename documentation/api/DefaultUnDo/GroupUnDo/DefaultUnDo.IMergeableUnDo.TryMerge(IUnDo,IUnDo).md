#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo\.DefaultUnDo\.IMergeableUnDo\.TryMerge\(IUnDo, IUnDo\) Method

Merges the current instance with the specified [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

```csharp
bool DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo other, out DefaultUnDo.IUnDo? mergedCommand);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo,DefaultUnDo.IUnDo).other'></a>

`other` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

The other [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') instance the current one should try to merge with\.

<a name='DefaultUnDo.GroupUnDo.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo,DefaultUnDo.IUnDo).mergedCommand'></a>

`mergedCommand` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

The resulting merged [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') instance if the operation was successful\.

Implements [TryMerge\(IUnDo, IUnDo\)](../IMergeableUnDo/TryMerge(IUnDo,IUnDo).md 'DefaultUnDo\.IMergeableUnDo\.TryMerge\(DefaultUnDo\.IUnDo, DefaultUnDo\.IUnDo\)')