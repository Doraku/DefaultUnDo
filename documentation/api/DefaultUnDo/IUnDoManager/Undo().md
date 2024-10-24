#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManager](index.md 'DefaultUnDo\.IUnDoManager')

## IUnDoManager\.Undo\(\) Method

Undoes the last executed [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\.

```csharp
void Undo();
```

#### Exceptions

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
Cannot perform [Undo\(\)](DefaultUnDo/IUnDoManager/Undo().md 'DefaultUnDo\.IUnDoManager\.Undo\(\)') while a group operation is going on\.

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
There is no action to undo\.