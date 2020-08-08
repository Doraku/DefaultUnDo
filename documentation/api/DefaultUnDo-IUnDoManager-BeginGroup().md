### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')
## IUnDoManager.BeginGroup() Method
Starts a group of operation and return an [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to stop the group.  
If multiple calls to this method are made, the group will be stoped once each [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') returned are disposed.  
```csharp
System.IDisposable BeginGroup();
```
#### Returns
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
An [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to stop the group operation.  
