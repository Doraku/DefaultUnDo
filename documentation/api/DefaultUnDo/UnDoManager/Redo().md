#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](index.md 'DefaultUnDo\.UnDoManager')

## UnDoManager\.Redo\(\) Method

Redoes the last undone [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\.

```csharp
public void Redo();
```

Implements [Redo\(\)](../IUnDoManager/Redo().md 'DefaultUnDo\.IUnDoManager\.Redo\(\)')

#### Exceptions

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
Cannot perform [Redo\(\)](Redo().md 'DefaultUnDo\.UnDoManager\.Redo\(\)') while a group operation is going on\.

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
There is no action to redo\.