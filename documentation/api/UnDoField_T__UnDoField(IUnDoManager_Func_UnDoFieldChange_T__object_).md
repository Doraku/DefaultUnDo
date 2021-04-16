#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;')
## UnDoField&lt;T&gt;.UnDoField(IUnDoManager, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;) Constructor
Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;').  
```csharp
public UnDoField(DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoFieldChange<T>,object> descriptionFactory=null);
```
#### Parameters
<a name='DefaultUnDo_UnDoField_T__UnDoField(DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoFieldChange_T__object_)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') used to register the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.
  
<a name='DefaultUnDo_UnDoField_T__UnDoField(DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoFieldChange_T__object_)_descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[DefaultUnDo.UnDoFieldChange&lt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;')[T](UnDoField_T_.md#DefaultUnDo_UnDoField_T__T 'DefaultUnDo.UnDoField&lt;T&gt;.T')[&gt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](UnDoField_T__UnDoField(IUnDoManager_Func_UnDoFieldChange_T__object_).md#DefaultUnDo_UnDoField_T__UnDoField(DefaultUnDo_IUnDoManager_System_Func_DefaultUnDo_UnDoFieldChange_T__object_)_manager 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;).manager') is null.
