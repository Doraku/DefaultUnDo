#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## ICollectionExtension Class
Provides a method to wrap an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class ICollectionExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ICollectionExtension  
### Methods

***
[AsUnDo&lt;T&gt;(ICollection&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](ICollectionExtension_AsUnDo_T_(ICollection_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')

Wraps an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
