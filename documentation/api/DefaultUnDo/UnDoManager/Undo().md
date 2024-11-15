#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](index.md 'DefaultUnDo\.UnDoManager')

## UnDoManager\.Undo\(\) Method

Undoes the last executed [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') command of the manager history\.

```csharp
public void Undo();
```

Implements [Undo\(\)](../IUnDoManager/Undo().md 'DefaultUnDo\.IUnDoManager\.Undo\(\)')

#### Exceptions

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
Cannot perform [Undo\(\)](Undo().md 'DefaultUnDo\.UnDoManager\.Undo\(\)') while a group operation is going on\.

[System\.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System\.InvalidOperationException')  
There is no action to undo\.