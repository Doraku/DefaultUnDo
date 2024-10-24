#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](index.md 'DefaultUnDo\.IUnDoManager')

## IUnDoManager\.Do\(IUnDo\) Method

Executes the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command and stores it in the manager hostory\.

```csharp
void Do(DefaultUnDo.IUnDo command);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo).command'></a>

`command` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

The [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') to execute\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[command](DefaultUnDo/IUnDoManager/Do(IUnDo).md#DefaultUnDo.IUnDoManager.Do(DefaultUnDo.IUnDo).command 'DefaultUnDo\.IUnDoManager\.Do\(DefaultUnDo\.IUnDo\)\.command') is null\.