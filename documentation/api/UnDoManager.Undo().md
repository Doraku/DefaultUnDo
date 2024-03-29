#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager')

## UnDoManager.Undo() Method

Undoes the last executed [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.

```csharp
public void Undo();
```

Implements [Undo()](IUnDoManager.Undo().md 'DefaultUnDo.IUnDoManager.Undo()')

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Undo()](UnDoManager.Undo().md 'DefaultUnDo.UnDoManager.Undo()') while a group operation is going on.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to undo.