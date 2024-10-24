#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## ValueUnDo Class

Provides a global [System\.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System\.TimeSpan') to use as default merge interval for all [ValueUnDo&lt;T&gt;](../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>')\.

```csharp
public static class ValueUnDo
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; ValueUnDo

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](MergeDescriptionAction.md 'DefaultUnDo\.ValueUnDo\.MergeDescriptionAction') | The [MergeDescriptionHandler\(object, object\)](MergeDescriptionHandler(object,object)/index.md 'DefaultUnDo\.ValueUnDo\.MergeDescriptionHandler\(object, object\)') used to merge description between two [ValueUnDo&lt;T&gt;](../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') instance\. |
| [MergeInterval](MergeInterval.md 'DefaultUnDo\.ValueUnDo\.MergeInterval') | The [System\.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System\.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') instances should respect to be mergeable\. Default value is 500ms\. |
