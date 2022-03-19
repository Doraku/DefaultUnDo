#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>')

## UnDoField(IUnDoManager, T, Func<UnDoFieldChange<T>,object>) Constructor

Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>').

```csharp
public UnDoField(DefaultUnDo.IUnDoManager manager, T value, System.Func<DefaultUnDo.UnDoFieldChange<T>,object?>? descriptionFactory=null);
```
#### Parameters

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') used to register the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).value'></a>

`value` [T](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo.UnDoField<T>.T')

The starting value of the [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>')

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).descriptionFactory'></a>

`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[DefaultUnDo.UnDoFieldChange&lt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange<T>')[T](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo.UnDoField<T>.T')[&gt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange<T>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Factory used to create the description of the generated [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](UnDoField_T_.UnDoField(IUnDoManager,T,Func_UnDoFieldChange_T_,object_).md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager 'DefaultUnDo.UnDoField<T>.UnDoField(DefaultUnDo.IUnDoManager, T, System.Func<DefaultUnDo.UnDoFieldChange<T>,object>).manager') is null.