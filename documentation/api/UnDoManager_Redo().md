#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.Redo() Method
Redoes the last undone [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.  
```csharp
public void Redo();
```
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Redo()](UnDoManager_Redo().md 'DefaultUnDo.UnDoManager.Redo()') while a group operation is going on.
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to redo.
