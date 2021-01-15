### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## UnDoField&lt;T&gt; Class
Provides a simple wrapper for a field to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public class UnDoField<T>
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDoField&lt;T&gt;  
#### Type parameters
<a name='DefaultUnDo-UnDoField-T--T'></a>
`T`  
  
  
### Constructors
- [UnDoField(DefaultUnDo.IUnDoManager, T, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)](./DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_T_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-).md 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, T, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)')
- [UnDoField(DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)](./DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-).md 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)')
### Properties
- [Value](./DefaultUnDo-UnDoField-T--Value.md 'DefaultUnDo.UnDoField&lt;T&gt;.Value')
### Methods
- [PostSet(T)](./DefaultUnDo-UnDoField-T--PostSet(T).md 'DefaultUnDo.UnDoField&lt;T&gt;.PostSet(T)')
- [PreSet(T)](./DefaultUnDo-UnDoField-T--PreSet(T).md 'DefaultUnDo.UnDoField&lt;T&gt;.PreSet(T)')
### Operators
- [implicit operator T(DefaultUnDo.UnDoField&lt;T&gt;)](./DefaultUnDo-UnDoField-T--op_ImplicitT(DefaultUnDo-UnDoField-T-).md 'DefaultUnDo.UnDoField&lt;T&gt;.op_Implicit T(DefaultUnDo.UnDoField&lt;T&gt;)')
