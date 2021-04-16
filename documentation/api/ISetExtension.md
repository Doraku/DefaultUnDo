#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## ISetExtension Class
Provides a method to wrap an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class ISetExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ISetExtension  
### Methods

***
[AsUnDo&lt;T&gt;(ISet&lt;T&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](ISetExtension_AsUnDo_T_(ISet_T__IUnDoManager_Func_UnDoCollectionOperation_object_).md 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')

Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
