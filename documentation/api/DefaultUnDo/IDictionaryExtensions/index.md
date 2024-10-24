#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## IDictionaryExtensions Class

Provides a method to wrap an [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') to an UnDo dictionary linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static class IDictionaryExtensions
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; IDictionaryExtensions

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;TKey,TValue&gt;\(this IDictionary&lt;TKey,TValue&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;\)](AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)') | Wraps an [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') to an UnDo dictionary linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\. |
