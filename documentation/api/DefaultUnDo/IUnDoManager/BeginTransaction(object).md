#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](index.md 'DefaultUnDo\.IUnDoManager')

## IUnDoManager\.BeginTransaction\(object\) Method

Starts a group of operation and return an [IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction') to stop the group\.
If [Commit\(\)](../IUnDoTransaction/Commit().md 'DefaultUnDo\.IUnDoTransaction\.Commit\(\)') is not called, all operations done during the transaction will be undone on [System\.IDisposable\.Dispose](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')\.

```csharp
DefaultUnDo.IUnDoTransaction BeginTransaction(object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManager.BeginTransaction(object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the group of operations\.

#### Returns
[IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction')  
An [IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction') to commit or rollback the transaction of operations\.