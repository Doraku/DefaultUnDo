#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## IUnDoManager Interface

Provides properties and methods of the command pattern to execute operations and return to a previous state by undoing them\.

```csharp
public interface IUnDoManager : System.ComponentModel.INotifyPropertyChanged
```

Derived  
&#8627; [UnDoManager](../UnDoManager/index.md 'DefaultUnDo\.UnDoManager')

Implements [System\.ComponentModel\.INotifyPropertyChanged](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.INotifyPropertyChanged 'System\.ComponentModel\.INotifyPropertyChanged')

| Properties | |
| :--- | :--- |
| [CanRedo](CanRedo.md 'DefaultUnDo\.IUnDoManager\.CanRedo') | Returns a boolean to express if the method [Redo\(\)](Redo().md 'DefaultUnDo\.IUnDoManager\.Redo\(\)') can be executed\. |
| [CanUndo](CanUndo.md 'DefaultUnDo\.IUnDoManager\.CanUndo') | Returns a boolean to express if the method [Undo\(\)](Undo().md 'DefaultUnDo\.IUnDoManager\.Undo\(\)') can be executed\. |
| [RedoDescriptions](RedoDescriptions.md 'DefaultUnDo\.IUnDoManager\.RedoDescriptions') | Gets the descriptions in order of all the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') which can be redone\. |
| [UndoDescriptions](UndoDescriptions.md 'DefaultUnDo\.IUnDoManager\.UndoDescriptions') | Gets the descriptions in order of all the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') which can be undone\. |
| [Version](Version.md 'DefaultUnDo\.IUnDoManager\.Version') | Gets an [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32') representing the state of the [IUnDoManager](DefaultUnDo/IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\. |

| Methods | |
| :--- | :--- |
| [BeginTransaction\(object\)](BeginTransaction(object).md 'DefaultUnDo\.IUnDoManager\.BeginTransaction\(object\)') | Starts a group of operation and return an [IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction') to stop the group\. If [Commit\(\)](../IUnDoTransaction/Commit().md 'DefaultUnDo\.IUnDoTransaction\.Commit\(\)') is not called, all operations done during the transaction will be undone on [System\.IDisposable\.Dispose](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System\.IDisposable\.Dispose')\. |
| [Clear\(\)](Clear().md 'DefaultUnDo\.IUnDoManager\.Clear\(\)') | Clears the history of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\. |
| [Do\(IUnDo\)](Do(IUnDo).md 'DefaultUnDo\.IUnDoManager\.Do\(DefaultUnDo\.IUnDo\)') | Executes the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command and stores it in the manager hostory\. |
| [Redo\(\)](Redo().md 'DefaultUnDo\.IUnDoManager\.Redo\(\)') | Redoes the last undone [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\. |
| [Undo\(\)](Undo().md 'DefaultUnDo\.IUnDoManager\.Undo\(\)') | Undoes the last executed [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\. |
