#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](index.md 'DefaultUnDo\.UnDoManager')

## UnDoManager\.Do\(IUnDo\) Method

Executes the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command and stores it in the manager hostory\.

```csharp
public void Do(DefaultUnDo.IUnDo command);
```
#### Parameters

<a name='DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo).command'></a>

`command` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

The [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') to execute\.

Implements [Do\(IUnDo\)](../IUnDoManager/Do(IUnDo).md 'DefaultUnDo\.IUnDoManager\.Do\(DefaultUnDo\.IUnDo\)')

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[command](DefaultUnDo/UnDoManager/Do(IUnDo).md#DefaultUnDo.UnDoManager.Do(DefaultUnDo.IUnDo).command 'DefaultUnDo\.UnDoManager\.Do\(DefaultUnDo\.IUnDo\)\.command') is null\.