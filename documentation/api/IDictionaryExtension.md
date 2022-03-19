#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## IDictionaryExtension Class

Provides a method to wrap an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

```csharp
public static class IDictionaryExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IDictionaryExtension

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;TKey,TValue&gt;(this IDictionary&lt;TKey,TValue&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>)') | Wraps an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations. |
