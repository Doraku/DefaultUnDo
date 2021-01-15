### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## IDictionaryExtension Class
Provides a method to wrap an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class IDictionaryExtension
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IDictionaryExtension  
### Methods
- [AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)](./DefaultUnDo-IDictionaryExtension-AsUnDo-TKey_TValue-(System-Collections-Generic-IDictionary-TKey_TValue-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-).md 'DefaultUnDo.IDictionaryExtension.AsUnDo&lt;TKey,TValue&gt;(System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')
