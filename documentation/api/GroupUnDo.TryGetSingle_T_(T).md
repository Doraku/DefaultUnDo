#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')

## GroupUnDo.TryGetSingle<T>(T) Method

Gets the single [T](GroupUnDo.TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo.GroupUnDo.TryGetSingle<T>(T).T') of this instance.

```csharp
public bool TryGetSingle<T>(out T command)
    where T : DefaultUnDo.IUnDo;
```
#### Type parameters

<a name='DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T'></a>

`T`
#### Parameters

<a name='DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).command'></a>

`command` [T](GroupUnDo.TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo.GroupUnDo.TryGetSingle<T>(T).T')

When this method returns, the single [T](GroupUnDo.TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo.GroupUnDo.TryGetSingle<T>(T).T') of this instance, if it was its only command; otherwise, the default value for the type [T](GroupUnDo.TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo.GroupUnDo.TryGetSingle<T>(T).T').  
This parameter is passed uninitialized.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the current instance contains exactly one [T](GroupUnDo.TryGetSingle_T_(T).md#DefaultUnDo.GroupUnDo.TryGetSingle_T_(T).T 'DefaultUnDo.GroupUnDo.TryGetSingle<T>(T).T'); otherwise false.