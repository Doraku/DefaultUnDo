#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDo](UnDo.md 'DefaultUnDo.UnDo')

## UnDo(Action, Action) Constructor

Initialises an instance of [UnDo](UnDo.md 'DefaultUnDo.UnDo').

```csharp
public UnDo(System.Action? doAction, System.Action? undoAction);
```
#### Parameters

<a name='DefaultUnDo.UnDo.UnDo(System.Action,System.Action).doAction'></a>

`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action called by [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()').

<a name='DefaultUnDo.UnDo.UnDo(System.Action,System.Action).undoAction'></a>

`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action called by [Undo()](IUnDo.Undo().md 'DefaultUnDo.IUnDo.Undo()').