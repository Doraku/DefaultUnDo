#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## ISetExtension Class

Provides a method to wrap an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

```csharp
public static class ISetExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ISetExtension

| Methods | |
| :--- | :--- |
| [AsUnDo&lt;T&gt;(this ISet&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](ISetExtension.AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md 'DefaultUnDo.ISetExtension.AsUnDo<T>(this System.Collections.Generic.ISet<T>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>)') | Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations. |
