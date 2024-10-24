#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](index.md 'DefaultUnDo\.UnDoManager')

## UnDoManager\.BeginTransaction\(object\) Method

Starts a group of operation and return an [IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction') to stop the group\.
If [Commit\(\)](../IUnDoTransaction/Commit().md 'DefaultUnDo\.IUnDoTransaction\.Commit\(\)') is not called, all operations done during the transaction will be undone on [System\.IDisposable\.Dispose](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable.Dispose 'System\.IDisposable\.Dispose')\.

```csharp
public DefaultUnDo.IUnDoTransaction BeginTransaction(object? description=null);
```
#### Parameters

<a name='DefaultUnDo.UnDoManager.BeginTransaction(object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the group of operations\.

Implements [BeginTransaction\(object\)](../IUnDoManager/BeginTransaction(object).md 'DefaultUnDo\.IUnDoManager\.BeginTransaction\(object\)')

#### Returns
[IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction')  
An [IUnDoTransaction](../IUnDoTransaction/index.md 'DefaultUnDo\.IUnDoTransaction') to commit or rollback the transaction of operations\.