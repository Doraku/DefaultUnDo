#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoOnUndo(IUnDoManager, Action, object) Method
Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no do.  
```csharp
public static void DoOnUndo(this DefaultUnDo.IUnDoManager manager, System.Action action, object description=null);
```
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_DoOnUndo(DefaultUnDo_IUnDoManager_System_Action_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoOnUndo(DefaultUnDo_IUnDoManager_System_Action_object)_action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Undo()](IUnDo_Undo().md 'DefaultUnDo.IUnDo.Undo()').
  
<a name='DefaultUnDo_IUnDoManagerExtension_DoOnUndo(DefaultUnDo_IUnDoManager_System_Action_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_DoOnUndo(IUnDoManager_Action_object).md#DefaultUnDo_IUnDoManagerExtension_DoOnUndo(DefaultUnDo_IUnDoManager_System_Action_object)_manager 'DefaultUnDo.IUnDoManagerExtension.DoOnUndo(DefaultUnDo.IUnDoManager, System.Action, object).manager') is null.
