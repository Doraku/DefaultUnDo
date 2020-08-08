### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ISetExtension](./DefaultUnDo-ISetExtension.md 'DefaultUnDo.ISetExtension')
## ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager) Method
Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.ISet<T> AsUnDo<T>(this System.Collections.Generic.ISet<T> source, DefaultUnDo.IUnDoManager manager);
```
#### Type parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
#### Parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
#### Returns
[System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
A wrapped [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-source 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager).source') or [manager](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager)-manager 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager).manager') is null.  
