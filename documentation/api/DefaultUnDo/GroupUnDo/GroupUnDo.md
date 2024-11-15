#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo Constructors

| Overloads | |
| :--- | :--- |
| [GroupUnDo\(object, scoped ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |
| [GroupUnDo\(scoped ReadOnlySpan&lt;IUnDo&gt;\)](GroupUnDo.md#DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_) 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)') | Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\. |

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_)'></a>

## GroupUnDo\(object, scoped ReadOnlySpan\<IUnDo\>\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(object? description, scoped System.ReadOnlySpan<DefaultUnDo.IUnDo> commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).commands'></a>

`commands` [System\.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System\.ReadOnlySpan\`1')[IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System\.ReadOnlySpan\`1')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(object,scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(object, scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') contains null elements\.

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_)'></a>

## GroupUnDo\(scoped ReadOnlySpan\<IUnDo\>\) Constructor

Initialise an instance of [GroupUnDo](index.md 'DefaultUnDo\.GroupUnDo')\.

```csharp
public GroupUnDo(scoped System.ReadOnlySpan<DefaultUnDo.IUnDo> commands);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).commands'></a>

`commands` [System\.ReadOnlySpan&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System\.ReadOnlySpan\`1')[IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ReadOnlySpan-1 'System\.ReadOnlySpan\`1')

The sequence of [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') contained by the instance\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') is null\.

[System\.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System\.ArgumentException')  
[commands](index.md#DefaultUnDo.GroupUnDo.GroupUnDo(scopedSystem.ReadOnlySpan_DefaultUnDo.IUnDo_).commands 'DefaultUnDo\.GroupUnDo\.GroupUnDo\(scoped System\.ReadOnlySpan\<DefaultUnDo\.IUnDo\>\)\.commands') contains null elements\.