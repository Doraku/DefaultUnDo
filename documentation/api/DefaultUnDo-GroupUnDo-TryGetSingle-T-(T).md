### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[GroupUnDo](./DefaultUnDo-GroupUnDo.md 'DefaultUnDo.GroupUnDo')
## GroupUnDo.TryGetSingle&lt;T&gt;(T) Method
Gets the single [T](#DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T') of this instance.  
```csharp
public bool TryGetSingle<T>(out T command);
```
#### Type parameters
<a name='DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T'></a>
`T`  
  
  
#### Parameters
<a name='DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-command'></a>
`command` [T](#DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T')  
When this method returns, the single [T](#DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T') of this instance, if it was its only command; otherwise, the default value for the type [T](#DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T').  
            This parameter is passed uninitialized.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the current instance contains exactly one [T](#DefaultUnDo-GroupUnDo-TryGetSingle-T-(T)-T 'DefaultUnDo.GroupUnDo.TryGetSingle&lt;T&gt;(T).T'); otherwise false.  
