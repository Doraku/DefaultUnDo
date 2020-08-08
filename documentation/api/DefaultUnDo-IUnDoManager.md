### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## IUnDoManager Interface
Provides properties and methods of the command pattern to execute operations and return to a previous state by undoing them.  
```csharp
public interface IUnDoManager :
INotifyPropertyChanged
```
Derived  
&#8627; [UnDoManager](./DefaultUnDo-UnDoManager.md 'DefaultUnDo.UnDoManager')  

Implements [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')  
### Properties
- [CanRedo](./DefaultUnDo-IUnDoManager-CanRedo.md 'DefaultUnDo.IUnDoManager.CanRedo')
- [CanUndo](./DefaultUnDo-IUnDoManager-CanUndo.md 'DefaultUnDo.IUnDoManager.CanUndo')
- [Version](./DefaultUnDo-IUnDoManager-Version.md 'DefaultUnDo.IUnDoManager.Version')
### Methods
- [BeginGroup()](./DefaultUnDo-IUnDoManager-BeginGroup().md 'DefaultUnDo.IUnDoManager.BeginGroup()')
- [Clear()](./DefaultUnDo-IUnDoManager-Clear().md 'DefaultUnDo.IUnDoManager.Clear()')
- [Do(DefaultUnDo.IUnDo)](./DefaultUnDo-IUnDoManager-Do(DefaultUnDo-IUnDo).md 'DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo)')
- [Redo()](./DefaultUnDo-IUnDoManager-Redo().md 'DefaultUnDo.IUnDoManager.Redo()')
- [Undo()](./DefaultUnDo-IUnDoManager-Undo().md 'DefaultUnDo.IUnDoManager.Undo()')
