#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo Constructors

| Overloads | |
| :--- | :--- |
| [GroupUnDo\(IUnDo\[\]\)](DefaultUnDo/GroupUnDo/GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[]) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(DefaultUnDo\.IUnDo\[\]\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |
| [GroupUnDo\(object, IUnDo\[\]\)](DefaultUnDo/GroupUnDo/GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, DefaultUnDo\.IUnDo\[\]\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[])'></a>

## GroupUnDo\(IUnDo\[\]\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(params DefaultUnDo.IUnDo[] commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[]).commands'></a>

`commands` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[]).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(DefaultUnDo\.IUnDo\[\]\)\.commands') is null\.

[System\.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(DefaultUnDo.IUnDo[]).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(DefaultUnDo\.IUnDo\[\]\)\.commands') contains null elements\.

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[])'></a>

## GroupUnDo\(object, IUnDo\[\]\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(object? description, params DefaultUnDo.IUnDo[] commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands'></a>

`commands` [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, DefaultUnDo\.IUnDo\[\]\)\.commands') is null\.

[System\.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,DefaultUnDo.IUnDo[]).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, DefaultUnDo\.IUnDo\[\]\)\.commands') contains null elements\.