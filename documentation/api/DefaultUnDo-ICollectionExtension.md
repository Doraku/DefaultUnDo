### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## ICollectionExtension Class
Provides a method to wrap an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class ICollectionExtension
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ICollectionExtension  
### Methods
- [AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)](./DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-).md 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')
