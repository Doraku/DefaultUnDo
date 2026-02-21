#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoTransaction](index.md 'DefaultUnDo\.IUnDoTransaction')

## IUnDoTransaction\.Commit\(\) Method

Groups all recorded operations in a single [GroupUnDo](../GroupUnDo/index.md 'DefaultUnDo\.GroupUnDo') and add it to the history of the [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') instance this instance was created from\.
If this method is not called before disposing current instance, all recorded operations will be undone\.

```csharp
void Commit();
```

#### Exceptions

[System\.ObjectDisposedException](https://learn.microsoft.com/en-us/dotnet/api/system.objectdisposedexception 'System\.ObjectDisposedException')

[System\.InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/system.invalidoperationexception 'System\.InvalidOperationException')  
Current transaction has already been committed

[System\.InvalidOperationException](https://learn.microsoft.com/en-us/dotnet/api/system.invalidoperationexception 'System\.InvalidOperationException')  
Current transaction is not the highest one on the stack