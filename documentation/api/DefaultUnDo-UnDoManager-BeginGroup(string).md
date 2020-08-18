### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[UnDoManager](./DefaultUnDo-UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.BeginGroup(string) Method
Starts a group of operation and return an [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to stop the group.  
If multiple calls to this method are made, the group will be stoped once each [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') returned are disposed.  
```csharp
public System.IDisposable BeginGroup(string description=null);
```
#### Parameters
<a name='DefaultUnDo-UnDoManager-BeginGroup(string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the group operation.  
  
#### Returns
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
An [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') to stop the group operation.  
