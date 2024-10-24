#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## ISetExtensions Class

Provides a method to wrap an [System\.Collections\.Generic\.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System\.Collections\.Generic\.ISet\`1') to an UnDo set linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static class ISetExtensions
```

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; ISetExtensions

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;T&gt;\(this ISet&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;\)](AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo\.ISetExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ISet\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)') | Wraps an [System\.Collections\.Generic\.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System\.Collections\.Generic\.ISet\`1') to an UnDo set linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\. |
