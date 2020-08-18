### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## UnDoManager Class
Provides an implementation of the command pattern to execute operations and return to a previous state by undoing them.  
```csharp
public sealed class UnDoManager :
IUnDoManager,
INotifyPropertyChanged
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDoManager  

Implements [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager'), [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')  
### Constructors
- [UnDoManager()](./DefaultUnDo-UnDoManager-UnDoManager().md 'DefaultUnDo.UnDoManager.UnDoManager()')
- [UnDoManager(int)](./DefaultUnDo-UnDoManager-UnDoManager(int).md 'DefaultUnDo.UnDoManager.UnDoManager(int)')
### Properties
- [CanRedo](./DefaultUnDo-UnDoManager-CanRedo.md 'DefaultUnDo.UnDoManager.CanRedo')
- [CanUndo](./DefaultUnDo-UnDoManager-CanUndo.md 'DefaultUnDo.UnDoManager.CanUndo')
- [RedoDescriptions](./DefaultUnDo-UnDoManager-RedoDescriptions.md 'DefaultUnDo.UnDoManager.RedoDescriptions')
- [UndoDescriptions](./DefaultUnDo-UnDoManager-UndoDescriptions.md 'DefaultUnDo.UnDoManager.UndoDescriptions')
- [Version](./DefaultUnDo-UnDoManager-Version.md 'DefaultUnDo.UnDoManager.Version')
### Methods
- [BeginGroup(string)](./DefaultUnDo-UnDoManager-BeginGroup(string).md 'DefaultUnDo.UnDoManager.BeginGroup(string)')
- [Clear()](./DefaultUnDo-UnDoManager-Clear().md 'DefaultUnDo.UnDoManager.Clear()')
- [Do(DefaultUnDo.IUnDo)](./DefaultUnDo-UnDoManager-Do(DefaultUnDo-IUnDo).md 'DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo)')
- [Redo()](./DefaultUnDo-UnDoManager-Redo().md 'DefaultUnDo.UnDoManager.Redo()')
- [Undo()](./DefaultUnDo-UnDoManager-Undo().md 'DefaultUnDo.UnDoManager.Undo()')
### Events
- [PropertyChanged](./DefaultUnDo-UnDoManager-PropertyChanged.md 'DefaultUnDo.UnDoManager.PropertyChanged')
