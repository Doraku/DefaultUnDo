#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')

## UnDoField\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [UnDoField\(IUnDoManager, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;\)](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_) 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)') | Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\. |
| [UnDoField\(IUnDoManager, T, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;\)](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_) 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, T, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)') | Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\. |

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_)'></a>

## UnDoField\(IUnDoManager, Func\<UnDoFieldChange\<T\>,object\>\) Constructor

Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\.

```csharp
public UnDoField(DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoFieldChange<T>,object?>? descriptionFactory=null);
```
#### Parameters

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') used to register the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[DefaultUnDo\.UnDoFieldChange&lt;](../UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[T](index.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo\.UnDoField\<T\>\.T')[&gt;](../UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)\.manager') is null\.

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_)'></a>

## UnDoField\(IUnDoManager, T, Func\<UnDoFieldChange\<T\>,object\>\) Constructor

Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\.

```csharp
public UnDoField(DefaultUnDo.IUnDoManager manager, T value, System.Func<DefaultUnDo.UnDoFieldChange<T>,object?>? descriptionFactory=null);
```
#### Parameters

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') used to register the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).value'></a>

`value` [T](index.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo\.UnDoField\<T\>\.T')

The starting value of the [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')

<a name='DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[DefaultUnDo\.UnDoFieldChange&lt;](../UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[T](index.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo\.UnDoField\<T\>\.T')[&gt;](../UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_).manager 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, T, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)\.manager') is null\.