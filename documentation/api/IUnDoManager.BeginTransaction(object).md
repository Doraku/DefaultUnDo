#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

## IUnDoManager.BeginTransaction(object) Method

Starts a group of operation and return an [IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction') to stop the group.  
If [Commit()](IUnDoTransaction.Commit().md 'DefaultUnDo.IUnDoTransaction.Commit()') is not called, all operations done during the transaction will be undone on [System.IDisposable.Dispose](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System.IDisposable.Dispose').

```csharp
DefaultUnDo.IUnDoTransaction BeginTransaction(object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManager.BeginTransaction(object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the group of operations.

#### Returns
[IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction')  
An [IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction') to commit or rollback the transaction of operations.