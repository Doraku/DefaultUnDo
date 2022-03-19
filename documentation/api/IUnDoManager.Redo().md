#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

## IUnDoManager.Redo() Method

Redoes the last undone [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.

```csharp
void Redo();
```

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Redo()](IUnDoManager.Redo().md 'DefaultUnDo.IUnDoManager.Redo()') while a group operation is going on.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to redo.