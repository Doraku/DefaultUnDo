#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## ValueUnDo Class
Provides a global [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to use as default merge interval for all [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').  
```csharp
public static class ValueUnDo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueUnDo  

| Properties | |
| :--- | :--- |
| [MergeDescriptionAction](ValueUnDo_MergeDescriptionAction.md 'DefaultUnDo.ValueUnDo.MergeDescriptionAction') | The [MergeDescriptionHandler(object, object)](ValueUnDo_MergeDescriptionHandler(object_object).md 'DefaultUnDo.ValueUnDo.MergeDescriptionHandler(object, object)') used to merge description between two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instance.<br/> |
| [MergeInterval](ValueUnDo_MergeInterval.md 'DefaultUnDo.ValueUnDo.MergeInterval') | The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances should respect to be mergeable.<br/>Default value is 500ms.<br/> |
