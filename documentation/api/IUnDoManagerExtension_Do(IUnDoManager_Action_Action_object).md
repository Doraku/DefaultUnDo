#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do(IUnDoManager, Action, Action, object) Method
Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified doAction and undoAction.  
```csharp
public static void Do(this DefaultUnDo.IUnDoManager manager, System.Action doAction, System.Action undoAction, object description=null);
```
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_Do(DefaultUnDo_IUnDoManager_System_Action_System_Action_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do(DefaultUnDo_IUnDoManager_System_Action_System_Action_object)_doAction'></a>
`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do(DefaultUnDo_IUnDoManager_System_Action_System_Action_object)_undoAction'></a>
`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by the [Undo()](IUnDo_Undo().md 'DefaultUnDo.IUnDo.Undo()').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do(DefaultUnDo_IUnDoManager_System_Action_System_Action_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_Do(IUnDoManager_Action_Action_object).md#DefaultUnDo_IUnDoManagerExtension_Do(DefaultUnDo_IUnDoManager_System_Action_System_Action_object)_manager 'DefaultUnDo.IUnDoManagerExtension.Do(DefaultUnDo.IUnDoManager, System.Action, System.Action, object).manager') is null.
