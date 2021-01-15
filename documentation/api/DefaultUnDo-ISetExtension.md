### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## ISetExtension Class
Provides a method to wrap an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class ISetExtension
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ISetExtension  
### Methods
- [AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)](./DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-).md 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')
