#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## IUnDoTransaction Interface
Represents a transaction to record multiple undo operations as a single operation in the history of a [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
```csharp
public interface IUnDoTransaction :
System.IDisposable
```

Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  

| Methods | |
| :--- | :--- |
| [Commit()](IUnDoTransaction_Commit().md 'DefaultUnDo.IUnDoTransaction.Commit()') | Groups all recorded operations in a single [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo') and add it to the history of the [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') instance this instance was created from.<br/>If this method is not called before disposing current instance, all recorded operations will be undone.<br/> |
