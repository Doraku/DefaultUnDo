#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>')

## ValueUnDo<T>.DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo, IUnDo) Method

Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').

```csharp
bool DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo other, out DefaultUnDo.IUnDo? mergedCommand);
```
#### Parameters

<a name='DefaultUnDo.ValueUnDo_T_.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo,DefaultUnDo.IUnDo).other'></a>

`other` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

The other [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance the current one should try to merge with.

<a name='DefaultUnDo.ValueUnDo_T_.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo,DefaultUnDo.IUnDo).mergedCommand'></a>

`mergedCommand` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

The resulting merged [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instance if the operation was successful.

Implements [TryMerge(IUnDo, IUnDo)](IMergeableUnDo.TryMerge(IUnDo,IUnDo).md 'DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)')