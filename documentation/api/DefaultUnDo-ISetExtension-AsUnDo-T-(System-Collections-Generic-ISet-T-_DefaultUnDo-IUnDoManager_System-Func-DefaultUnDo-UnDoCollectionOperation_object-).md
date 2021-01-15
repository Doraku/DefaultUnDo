### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ISetExtension](./DefaultUnDo-ISetExtension.md 'DefaultUnDo.ISetExtension')
## ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;) Method
Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.ISet<T> AsUnDo<T>(this System.Collections.Generic.ISet<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
#### Parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnDoCollectionOperation](./DefaultUnDo-UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo').  
  
#### Returns
[System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
A wrapped [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-source 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).source') or [manager](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-DefaultUnDo-UnDoCollectionOperation_object-)-manager 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoCollectionOperation,object&gt;).manager') is null.  
