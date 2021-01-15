### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## IUnDoTransaction Interface
Represents a transaction to record multiple undo operations as a single operation in the history of a [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
```csharp
public interface IUnDoTransaction :
IDisposable
```
Implements [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
### Methods
- [Commit()](./DefaultUnDo-IUnDoTransaction-Commit().md 'DefaultUnDo.IUnDoTransaction.Commit()')
