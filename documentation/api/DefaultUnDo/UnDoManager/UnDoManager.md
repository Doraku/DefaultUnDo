#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoManager](index.md 'DefaultUnDo\.UnDoManager')

## UnDoManager Constructors

| Overloads | |
| :--- | :--- |
| [UnDoManager\(\)](DefaultUnDo/UnDoManager/UnDoManager.md#DefaultUnDo.UnDoManager.UnDoManager() 'DefaultUnDo\.UnDoManager\.UnDoManager\(\)') | Initialises an instance of [UnDoManager](index.md 'DefaultUnDo\.UnDoManager')\. |
| [UnDoManager\(int\)](DefaultUnDo/UnDoManager/UnDoManager.md#DefaultUnDo.UnDoManager.UnDoManager(int) 'DefaultUnDo\.UnDoManager\.UnDoManager\(int\)') | Initialises an instance of [UnDoManager](index.md 'DefaultUnDo\.UnDoManager')\. |

<a name='DefaultUnDo.UnDoManager.UnDoManager()'></a>

## UnDoManager\(\) Constructor

Initialises an instance of [UnDoManager](index.md 'DefaultUnDo\.UnDoManager')\.

```csharp
public UnDoManager();
```

<a name='DefaultUnDo.UnDoManager.UnDoManager(int)'></a>

## UnDoManager\(int\) Constructor

Initialises an instance of [UnDoManager](index.md 'DefaultUnDo\.UnDoManager')\.

```csharp
public UnDoManager(int maxCapacity);
```
#### Parameters

<a name='DefaultUnDo.UnDoManager.UnDoManager(int).maxCapacity'></a>

`maxCapacity` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The maximum number of operation this [UnDoManager](index.md 'DefaultUnDo\.UnDoManager') can record before errasing oldest ones\.