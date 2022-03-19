#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDo](UnDo.md 'DefaultUnDo.UnDo')

## UnDo(object, Action, Action) Constructor

Initialises an instance of [UnDo](UnDo.md 'DefaultUnDo.UnDo').

```csharp
public UnDo(object? description, System.Action? doAction, System.Action? undoAction);
```
#### Parameters

<a name='DefaultUnDo.UnDo.UnDo(object,System.Action,System.Action).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

<a name='DefaultUnDo.UnDo.UnDo(object,System.Action,System.Action).doAction'></a>

`doAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action called by [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()').

<a name='DefaultUnDo.UnDo.UnDo(object,System.Action,System.Action).undoAction'></a>

`undoAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action called by [Undo()](IUnDo.Undo().md 'DefaultUnDo.IUnDo.Undo()').