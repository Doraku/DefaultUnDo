#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo Constructors

| Overloads | |
| :--- | :--- |
| [GroupUnDo\(object, ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,System.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |
| [GroupUnDo\(ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(System.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,System.ReadOnlySpan_DefaultUnDo.IUnDo_)'></a>

## GroupUnDo\(object, ReadOnlySpan\<IUnDo\>\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(object? description, scoped System.ReadOnlySpan<DefaultUnDo.IUnDo> commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,System.ReadOnlySpan_DefaultUnDo.IUnDo_).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,System.ReadOnlySpan_DefaultUnDo.IUnDo_).commands'></a>

`commands` [System\.ReadOnlySpan&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1 'System\.ReadOnlySpan\`1')[IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1 'System\.ReadOnlySpan\`1')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,System.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') contains null elements\.

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(System.ReadOnlySpan_DefaultUnDo.IUnDo_)'></a>

## GroupUnDo\(ReadOnlySpan\<IUnDo\>\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(scoped System.ReadOnlySpan<DefaultUnDo.IUnDo> commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(System.ReadOnlySpan_DefaultUnDo.IUnDo_).commands'></a>

`commands` [System\.ReadOnlySpan&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1 'System\.ReadOnlySpan\`1')[IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1 'System\.ReadOnlySpan\`1')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(System.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') is null\.

[System\.ArgumentException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentexception 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(System.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') contains null elements\.