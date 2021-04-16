#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## IDictionaryExtension Class
Provides a method to wrap an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class IDictionaryExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IDictionaryExtension  
### Methods

***
[AsUnDo&lt;TKey,TValue&gt;(IDictionary&lt;TKey,TValue&gt;, IUnDoManager, Func&lt;UnDoCollectionOperation,object&gt;)](IDictionaryExtension_AsUnDo_TKey_TValue_(IDictionary_TKey_TValue__IUnDoManager_Func_UnDoCollectionOperation_object_).md 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')

Wraps an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
