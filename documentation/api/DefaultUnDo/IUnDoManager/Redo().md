#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](index.md 'DefaultUnDo\.IUnDoManager')

## IUnDoManager\.Redo\(\) Method

Redoes the last undone [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\.

```csharp
void Redo();
```

#### Exceptions

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
Cannot perform [Redo\(\)](DefaultUnDo/IUnDoManager/Redo().md 'DefaultUnDo\.IUnDoManager\.Redo\(\)') while a group operation is going on\.

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
There is no action to redo\.