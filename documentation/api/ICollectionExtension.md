#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## ICollectionExtension Class

Provides a method to wrap an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

```csharp
public static class ICollectionExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ICollectionExtension

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;T&gt;(this ICollection&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](ICollectionExtension.AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo.ICollectionExtension.AsUnDo<T>(this System.Collections.Generic.ICollection<T>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>)') | Wraps an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations. |
