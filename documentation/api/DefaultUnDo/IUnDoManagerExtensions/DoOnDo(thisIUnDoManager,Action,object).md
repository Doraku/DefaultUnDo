#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoOnDo\(this IUnDoManager, Action, object\) Method

Does a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation on the manager with the specified action with no undo\.

```csharp
public static void DoOnDo(this DefaultUnDo.IUnDoManager manager, System.Action action, object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnDo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnDo(thisDefaultUnDo.IUnDoManager,System.Action,object).action'></a>

`action` [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action')

The [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action') performed by [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnDo(thisDefaultUnDo.IUnDoManager,System.Action,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](DoOnDo(thisIUnDoManager,Action,object).md#DefaultUnDo.IUnDoManagerExtensions.DoOnDo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoOnDo\(this DefaultUnDo\.IUnDoManager, System\.Action, object\)\.manager') is null\.