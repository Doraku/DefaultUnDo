### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do(DefaultUnDo.IUnDoManager, System.Action, System.Action) Method
Does a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified doAction and undoAction.  
```csharp
public static void Do(this DefaultUnDo.IUnDoManager manager, System.Action doAction, System.Action undoAction);
```
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do(DefaultUnDo-IUnDoManager_System-Action_System-Action)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do(DefaultUnDo-IUnDoManager_System-Action_System-Action)-doAction'></a>
`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Do()](./DefaultUnDo-IUnDo-Do().md 'DefaultUnDo.IUnDo.Do()').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do(DefaultUnDo-IUnDoManager_System-Action_System-Action)-undoAction'></a>
`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by the [Undo()](./DefaultUnDo-IUnDo-Undo().md 'DefaultUnDo.IUnDo.Undo()').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-Do(DefaultUnDo-IUnDoManager_System-Action_System-Action)-manager 'DefaultUnDo.IUnDoManagerExtension.Do(DefaultUnDo.IUnDoManager, System.Action, System.Action).manager') is null.  
