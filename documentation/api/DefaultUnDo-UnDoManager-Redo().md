### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[UnDoManager](./DefaultUnDo-UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.Redo() Method
Redoes the last undone [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.  
```csharp
public void Redo();
```
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Redo()](./DefaultUnDo-UnDoManager-Redo().md 'DefaultUnDo.UnDoManager.Redo()') while a group operation is going on.  
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to redo.  
