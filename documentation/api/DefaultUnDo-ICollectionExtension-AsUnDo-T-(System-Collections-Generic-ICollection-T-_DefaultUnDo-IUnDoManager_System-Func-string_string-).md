### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ICollectionExtension](./DefaultUnDo-ICollectionExtension.md 'DefaultUnDo.ICollectionExtension')
## ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;) Method
Wraps an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.ICollection<T> AsUnDo<T>(this System.Collections.Generic.ICollection<T> source, DefaultUnDo.IUnDoManager manager, System.Func<string,string> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
#### Parameters
<a name='DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](#DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
<a name='DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo'), the name of the method called is passed as a parameter.  
  
#### Returns
[System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](#DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
A wrapped [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).source') or [manager](#DefaultUnDo-ICollectionExtension-AsUnDo-T-(System-Collections-Generic-ICollection-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager 'DefaultUnDo.ICollectionExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ICollection&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).manager') is null.  
