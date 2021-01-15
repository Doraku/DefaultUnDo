### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoOnDo(DefaultUnDo.IUnDoManager, System.Action, object) Method
Does a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no undo.  
```csharp
public static void DoOnDo(this DefaultUnDo.IUnDoManager manager, System.Action action, object description=null);
```
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action_object)-action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Do()](./DefaultUnDo-IUnDo-Do().md 'DefaultUnDo.IUnDo.Do()').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action_object)-manager 'DefaultUnDo.IUnDoManagerExtension.DoOnDo(DefaultUnDo.IUnDoManager, System.Action, object).manager') is null.  
