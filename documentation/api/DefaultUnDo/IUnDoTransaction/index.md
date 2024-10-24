#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## IUnDoTransaction Interface

Represents a transaction to record multiple undo operations as a single operation in the history of a [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

```csharp
public interface IUnDoTransaction : System.IDisposable
```

Implements [System\.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System\.IDisposable')

| Methods | |
| :--- | :--- |
| [Commit\(\)](Commit().md 'DefaultUnDo\.IUnDoTransaction\.Commit\(\)') | Groups all recorded operations in a single [GroupUnDo](../GroupUnDo/index.md 'DefaultUnDo\.GroupUnDo') and add it to the history of the [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') instance this instance was created from\. If this method is not called before disposing current instance, all recorded operations will be undone\. |
