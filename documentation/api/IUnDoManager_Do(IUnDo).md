#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')
## IUnDoManager.Do(IUnDo) Method
Executes the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and stores it in the manager hostory.  
```csharp
void Do(DefaultUnDo.IUnDo command);
```
#### Parameters
<a name='DefaultUnDo_IUnDoManager_Do(DefaultUnDo_IUnDo)_command'></a>
`command` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') to execute.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[command](IUnDoManager_Do(IUnDo).md#DefaultUnDo_IUnDoManager_Do(DefaultUnDo_IUnDo)_command 'DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo).command') is null.
