#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager')
## UnDoManager.Do(IUnDo) Method
Executes the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and stores it in the manager hostory.  
```csharp
public void Do(DefaultUnDo.IUnDo command);
```
#### Parameters
<a name='DefaultUnDo_UnDoManager_Do(DefaultUnDo_IUnDo)_command'></a>
`command` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
The [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') to execute.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[command](UnDoManager_Do(IUnDo).md#DefaultUnDo_UnDoManager_Do(DefaultUnDo_IUnDo)_command 'DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo).command') is null.

Implements [Do(IUnDo)](IUnDoManager_Do(IUnDo).md 'DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo)')  
