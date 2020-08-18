### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ISetExtension](./DefaultUnDo-ISetExtension.md 'DefaultUnDo.ISetExtension')
## ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;) Method
Wraps an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public static System.Collections.Generic.ISet<T> AsUnDo<T>(this System.Collections.Generic.ISet<T> source, DefaultUnDo.IUnDoManager manager, System.Func<string,string> descriptionFactory=null);
```
#### Type parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
#### Parameters
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-descriptionFactory'></a>
`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Factory used to create the description of the generated [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo'), the name of the method called is passed as a parameter.  
  
#### Returns
[System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-T 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
A wrapped [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-source 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).source') or [manager](#DefaultUnDo-ISetExtension-AsUnDo-T-(System-Collections-Generic-ISet-T-_DefaultUnDo-IUnDoManager_System-Func-string_string-)-manager 'DefaultUnDo.ISetExtension.AsUnDo&lt;T&gt;(System.Collections.Generic.ISet&lt;T&gt;, DefaultUnDo.IUnDoManager, System.Func&lt;string,string&gt;).manager') is null.  
