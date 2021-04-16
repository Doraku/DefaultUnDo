#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDo](UnDo.md 'DefaultUnDo.UnDo')
## UnDo.UnDo(object, Action, Action) Constructor
Initialises an instance of [UnDo](UnDo.md 'DefaultUnDo.UnDo').  
```csharp
public UnDo(object description, System.Action doAction, System.Action undoAction);
```
#### Parameters
<a name='DefaultUnDo_UnDo_UnDo(object_System_Action_System_Action)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')
  
<a name='DefaultUnDo_UnDo_UnDo(object_System_Action_System_Action)_doAction'></a>
`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action called by [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()').
  
<a name='DefaultUnDo_UnDo_UnDo(object_System_Action_System_Action)_undoAction'></a>
`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action called by [Undo()](IUnDo_Undo().md 'DefaultUnDo.IUnDo.Undo()').
  
