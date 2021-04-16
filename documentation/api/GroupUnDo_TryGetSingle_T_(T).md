#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')
## GroupUnDo.TryGetSingle&lt;T&gt;(T) Method
Gets the single [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T') of this instance.  
```csharp
public bool TryGetSingle<T>(out T command)
    where T : DefaultUnDo.IUnDo;
```
#### Type parameters
<a name='DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T'></a>
`T`  
  
#### Parameters
<a name='DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_command'></a>
`command` [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T')  
When this method returns, the single [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T') of this instance, if it was its only command; otherwise, the default value for the type [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T').  
This parameter is passed uninitialized.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the current instance contains exactly one [T](GroupUnDo_TryGetSingle_T_(T).md#DefaultUnDo_GroupUnDo_TryGetSingle_T_(T)_T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T'); otherwise false.
