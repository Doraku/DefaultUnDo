#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## ICollectionExtensions Class

Provides a method to wrap an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1') to an UnDo collection linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static class ICollectionExtensions
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; ICollectionExtensions

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;T&gt;\(this ICollection&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;\)](AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo\.ICollectionExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ICollection\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)') | Wraps an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1') to an UnDo collection linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\. |
