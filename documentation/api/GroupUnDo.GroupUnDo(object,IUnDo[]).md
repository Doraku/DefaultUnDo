#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')

## GroupUnDo(object, IUnDo[]) Constructor

Initialise an instance of [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo').

```csharp
public GroupUnDo(object? description, params DefaultUnDo.IUnDo[] commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands'></a>

`commands` [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The sequence of [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') contained by the instance.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[commands](GroupUnDo.GroupUnDo(object,IUnDo[]).md#DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[]).commands') is null.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[commands](GroupUnDo.GroupUnDo(object,IUnDo[]).md#DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[]).commands') contains null elements.