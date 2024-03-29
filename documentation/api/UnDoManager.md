#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## UnDoManager Class

Provides an implementation of the command pattern to execute operations and return to a previous state by undoing them.

```csharp
public sealed class UnDoManager :
DefaultUnDo.IUnDoManager,
System.ComponentModel.INotifyPropertyChanged
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDoManager

Implements [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager'), [System.ComponentModel.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged')

| Constructors | |
| :--- | :--- |
| [UnDoManager()](UnDoManager.UnDoManager().md 'DefaultUnDo.UnDoManager.UnDoManager()') | Initialises an instance of [UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager'). |
| [UnDoManager(int)](UnDoManager.UnDoManager(int).md 'DefaultUnDo.UnDoManager.UnDoManager(int)') | Initialises an instance of [UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager'). |

| Properties | |
| :--- | :--- |
| [CanRedo](UnDoManager.CanRedo.md 'DefaultUnDo.UnDoManager.CanRedo') | Returns a boolean to express if the method [Redo()](UnDoManager.Redo().md 'DefaultUnDo.UnDoManager.Redo()') can be executed. |
| [CanUndo](UnDoManager.CanUndo.md 'DefaultUnDo.UnDoManager.CanUndo') | Returns a boolean to express if the method [Undo()](UnDoManager.Undo().md 'DefaultUnDo.UnDoManager.Undo()') can be executed. |
| [RedoDescriptions](UnDoManager.RedoDescriptions.md 'DefaultUnDo.UnDoManager.RedoDescriptions') | Gets the descriptions in order of all the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') which can be redone. |
| [UndoDescriptions](UnDoManager.UndoDescriptions.md 'DefaultUnDo.UnDoManager.UndoDescriptions') | Gets the descriptions in order of all the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') which can be undone. |
| [Version](UnDoManager.Version.md 'DefaultUnDo.UnDoManager.Version') | Gets an [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32') representing the state of the [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager'). |

| Methods | |
| :--- | :--- |
| [BeginTransaction(object)](UnDoManager.BeginTransaction(object).md 'DefaultUnDo.UnDoManager.BeginTransaction(object)') | Starts a group of operation and return an [IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction') to stop the group.<br/>If [Commit()](IUnDoTransaction.Commit().md 'DefaultUnDo.IUnDoTransaction.Commit()') is not called, all operations done during the transaction will be undone on [System.IDisposable.Dispose](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose'). |
| [Clear()](UnDoManager.Clear().md 'DefaultUnDo.UnDoManager.Clear()') | Clears the history of [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations. |
| [Do(IUnDo)](UnDoManager.Do(IUnDo).md 'DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo)') | Executes the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and stores it in the manager hostory. |
| [Redo()](UnDoManager.Redo().md 'DefaultUnDo.UnDoManager.Redo()') | Redoes the last undone [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history. |
| [Undo()](UnDoManager.Undo().md 'DefaultUnDo.UnDoManager.Undo()') | Undoes the last executed [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command of the manager history. |

| Events | |
| :--- | :--- |
| [PropertyChanged](UnDoManager.PropertyChanged.md 'DefaultUnDo.UnDoManager.PropertyChanged') | Occurs when a property value changes. |
