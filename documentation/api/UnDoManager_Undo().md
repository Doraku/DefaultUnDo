#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.Undo() Method
Undoes the last executed [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history.  
```csharp
public void Undo();
```
#### Exceptions
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Cannot perform [Undo()](UnDoManager_Undo().md 'DefaultUnDo.UnDoManager.Undo()') while a group operation is going on.
[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
There is no action to undo.

Implements [Undo()](IUnDoManager_Undo().md 'DefaultUnDo.IUnDoManager.Undo()')  
