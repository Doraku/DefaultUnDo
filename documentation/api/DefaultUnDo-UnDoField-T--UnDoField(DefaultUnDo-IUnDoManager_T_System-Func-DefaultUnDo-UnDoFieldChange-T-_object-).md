### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[UnDoField&lt;T&gt;](./DefaultUnDo-UnDoField-T-.md 'DefaultUnDo.UnDoField&lt;T&gt;')
## UnDoField(DefaultUnDo.IUnDoManager, T, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;) Constructor
Creates a new instance of [UnDoField&lt;T&gt;](./DefaultUnDo-UnDoField-T-.md 'DefaultUnDo.UnDoField&lt;T&gt;').  
```csharp
public UnDoField(DefaultUnDo.IUnDoManager manager, T value, System.Func<DefaultUnDo.UnDoFieldChange<T>,object> descriptionFactory=null);
```
#### Parameters
<a name='DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_T_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') used to register the [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
  
<a name='DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_T_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-)-value'></a>
`value` [T](./DefaultUnDo-UnDoField-T-.md#DefaultUnDo-UnDoField-T--T 'DefaultUnDo.UnDoField&lt;T&gt;.T')  
The starting value of the [UnDoField&lt;T&gt;](./DefaultUnDo-UnDoField-T-.md 'DefaultUnDo.UnDoField&lt;T&gt;')  
  
<a name='DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_T_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-)-descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[DefaultUnDo.UnDoFieldChange&lt;](./DefaultUnDo-UnDoFieldChange-T-.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;')[T](./DefaultUnDo-UnDoField-T-.md#DefaultUnDo-UnDoField-T--T 'DefaultUnDo.UnDoField&lt;T&gt;.T')[&gt;](./DefaultUnDo-UnDoFieldChange-T-.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-UnDoField-T--UnDoField(DefaultUnDo-IUnDoManager_T_System-Func-DefaultUnDo-UnDoFieldChange-T-_object-)-manager 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, T, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;).manager') is null.  
