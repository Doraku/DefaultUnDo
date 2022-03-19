#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

## IUnDoManager.Undo() Method

Undoes the last executed [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.

```csharp
void Undo();
```

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Undo()](IUnDoManager.Undo().md 'DefaultUnDo.IUnDoManager.Undo()') while a group operation is going on.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to undo.