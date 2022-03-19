#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoOnUndo(this IUnDoManager, Action, object) Method

Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no do.

```csharp
public static void DoOnUndo(this DefaultUnDo.IUnDoManager manager, System.Action action, object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Undo()](IUnDo.Undo().md 'DefaultUnDo.IUnDo.Undo()').

<a name='DefaultUnDo.IUnDoManagerExtension.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoOnUndo(thisIUnDoManager,Action,object).md#DefaultUnDo.IUnDoManagerExtension.DoOnUndo(thisDefaultUnDo.IUnDoManager,System.Action,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoOnUndo(this DefaultUnDo.IUnDoManager, System.Action, object).manager') is null.