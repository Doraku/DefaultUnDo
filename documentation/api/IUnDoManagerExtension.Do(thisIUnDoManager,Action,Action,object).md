#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.Do(this IUnDoManager, Action, Action, object) Method

Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified doAction and undoAction.

```csharp
public static void Do(this DefaultUnDo.IUnDoManager manager, System.Action? doAction, System.Action? undoAction, object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).doAction'></a>

`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()').

<a name='DefaultUnDo.IUnDoManagerExtension.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).undoAction'></a>

`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action') performed by the [Undo()](IUnDo.Undo().md 'DefaultUnDo.IUnDo.Undo()').

<a name='DefaultUnDo.IUnDoManagerExtension.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.Do(thisIUnDoManager,Action,Action,object).md#DefaultUnDo.IUnDoManagerExtension.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).manager 'DefaultUnDo.IUnDoManagerExtension.Do(this DefaultUnDo.IUnDoManager, System.Action, System.Action, object).manager') is null.