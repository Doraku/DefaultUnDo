### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[UnDo](./DefaultUnDo-UnDo.md 'DefaultUnDo.UnDo')
## UnDo(string, System.Action, System.Action) Constructor
Initialises an instance of [UnDo](./DefaultUnDo-UnDo.md 'DefaultUnDo.UnDo').  
```csharp
public UnDo(string description, System.Action doAction, System.Action undoAction);
```
#### Parameters
<a name='DefaultUnDo-UnDo-UnDo(string_System-Action_System-Action)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of this [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
  
<a name='DefaultUnDo-UnDo-UnDo(string_System-Action_System-Action)-doAction'></a>
`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action called by [Do()](./DefaultUnDo-IUnDo-Do().md 'DefaultUnDo.IUnDo.Do()').  
  
<a name='DefaultUnDo-UnDo-UnDo(string_System-Action_System-Action)-undoAction'></a>
`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')  
The action called by [Undo()](./DefaultUnDo-IUnDo-Undo().md 'DefaultUnDo.IUnDo.Undo()').  
  