### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoOnDo(DefaultUnDo.IUnDoManager, System.Action) Method
Does a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no undo.  
```csharp
public static void DoOnDo(this DefaultUnDo.IUnDoManager manager, System.Action action);
```
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action)-action'></a>
`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Do()](./DefaultUnDo-IUnDo-Do().md 'DefaultUnDo.IUnDo.Do()').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoOnDo(DefaultUnDo-IUnDoManager_System-Action)-manager 'DefaultUnDo.IUnDoManagerExtension.DoOnDo(DefaultUnDo.IUnDoManager, System.Action).manager') is null.  
