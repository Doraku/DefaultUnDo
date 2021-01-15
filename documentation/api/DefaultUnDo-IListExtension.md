### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## IListExtension Class
Provides a method to wrap an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static class IListExtension
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IListExtension  
### Methods
- [AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)](./DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-).md 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;)')
- [Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int)](./DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int).md 'DefaultUnDo.IListExtension.Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int)')
