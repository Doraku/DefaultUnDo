#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoOnUndo\(this IUnDoManager, Action, object\) Method

Does a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation on the manager with the specified action with no do\.

```csharp
public static void DoOnUndo(this DefaultUnDo.IUnDoManager manager, System.Action action, object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).action'></a>

`action` [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action')

The [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action') performed by [Undo\(\)](../IUnDo/Undo().md 'DefaultUnDo\.IUnDo\.Undo\(\)')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](DefaultUnDo/IUnDoManagerExtensions/DoOnUndo(thisIUnDoManager,Action,object).md#DefaultUnDo.IUnDoManagerExtensions.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoOnUndo\(this DefaultUnDo\.IUnDoManager, System\.Action, object\)\.manager') is null\.