#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## UnDo Class

Provides an implementation of the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') interface for custom do and undo action\.

```csharp
public sealed class UnDo : DefaultUnDo.IUnDo
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; UnDo

Implements [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

| Constructors | |
| :--- | :--- |
| [UnDo\(object, Action, Action\)](UnDo.md#DefaultUnDo.UnDo.UnDo(object,System.Action,System.Action) 'DefaultUnDo\.UnDo\.UnDo\(object, System\.Action, System\.Action\)') | Initialises an instance of [UnDo](DefaultUnDo/UnDo/index.md 'DefaultUnDo\.UnDo')\. |
| [UnDo\(Action, Action\)](UnDo.md#DefaultUnDo.UnDo.UnDo(System.Action,System.Action) 'DefaultUnDo\.UnDo\.UnDo\(System\.Action, System\.Action\)') | Initialises an instance of [UnDo](DefaultUnDo/UnDo/index.md 'DefaultUnDo\.UnDo')\. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo\.IUnDo\.Description](DefaultUnDo.IUnDo.Description.md 'DefaultUnDo\.UnDo\.DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') perform\. |
| [DefaultUnDo\.IUnDo\.Do\(\)](DefaultUnDo.IUnDo.Do().md 'DefaultUnDo\.UnDo\.DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [DefaultUnDo\.IUnDo\.Undo\(\)](DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo\.UnDo\.DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
