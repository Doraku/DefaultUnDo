#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## ValueUnDo Class

Provides a global [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to use as default merge interval for all [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>').

```csharp
public static class ValueUnDo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueUnDo

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](ValueUnDo.MergeDescriptionAction.md 'DefaultUnDo.ValueUnDo.MergeDescriptionAction') | The [MergeDescriptionHandler(object, object)](ValueUnDo.MergeDescriptionHandler(object,object).md 'DefaultUnDo.ValueUnDo.MergeDescriptionHandler(object, object)') used to merge description between two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') instance. |
| [MergeInterval](ValueUnDo.MergeInterval.md 'DefaultUnDo.ValueUnDo.MergeInterval') | The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') instances should respect to be mergeable.<br/>Default value is 500ms. |
