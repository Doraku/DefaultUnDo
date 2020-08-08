### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IListExtension](./DefaultUnDo-IListExtension.md 'DefaultUnDo.IListExtension')
## IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager) Method
Wraps an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.IList<T> AsUnDo<T>(this System.Collections.Generic.IList<T> source, DefaultUnDo.IUnDoManager manager);
```
#### Type parameters
<a name='DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
#### Parameters
<a name='DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-T 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
<a name='DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
#### Returns
[System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-T 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
A wrapped [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-source 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager).source') or [manager](#DefaultUnDo-IListExtension-AsUnDo-T-(System-Collections-Generic-IList-T-_DefaultUnDo-IUnDoManager)-manager 'DefaultUnDo.IListExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, DefaultUnDo.IUnDoManager).manager') is null.  
