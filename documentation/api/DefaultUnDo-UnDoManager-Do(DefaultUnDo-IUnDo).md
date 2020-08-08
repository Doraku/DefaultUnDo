### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[UnDoManager](./DefaultUnDo-UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.Do(DefaultUnDo.IUnDo) Method
Executes the [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') command and stores it in the manager hostory.  
```csharp
public void Do(DefaultUnDo.IUnDo command);
```
#### Parameters
<a name='DefaultUnDo-UnDoManager-Do(DefaultUnDo-IUnDo)-command'></a>
`command` [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
The [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') to execute.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[command](#DefaultUnDo-UnDoManager-Do(DefaultUnDo-IUnDo)-command 'DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo).command') is null.  
