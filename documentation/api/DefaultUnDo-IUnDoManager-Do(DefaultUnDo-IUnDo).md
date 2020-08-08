### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')
## IUnDoManager.Do(DefaultUnDo.IUnDo) Method
Executes the [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') command and stores it in the manager hostory.  
```csharp
void Do(DefaultUnDo.IUnDo command);
```
#### Parameters
<a name='DefaultUnDo-IUnDoManager-Do(DefaultUnDo-IUnDo)-command'></a>
`command` [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
The [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') to execute.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[command](#DefaultUnDo-IUnDoManager-Do(DefaultUnDo-IUnDo)-command 'DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo).command') is null.  
