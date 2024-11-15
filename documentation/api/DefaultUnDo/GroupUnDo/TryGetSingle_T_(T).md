#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo\.TryGetSingle\<T\>\(T\) Method

Gets the single [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T') of this instance\.

```csharp
public bool TryGetSingle<T>(out T command)
    where T : class, DefaultUnDo.IUnDo;
```
#### Type parameters

<a name='DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T'></a>

`T`

The type of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') to get\.
#### Parameters

<a name='DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).command'></a>

`command` [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T')

When this method returns, the single [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T') of this instance, if it was its only command; otherwise, the default value for the type [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T')\.
This parameter is passed uninitialized\.

#### Returns
[System\.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System\.Boolean')  
true if the current instance contains exactly one [T](TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo\.GroupUnDo\.TryGetSingle\<T\>\(T\)\.T'); otherwise false\.