### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object) Method
Clears a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoClear<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-T 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-manager 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).manager') or [source](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_object)-source 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object).source') is null.  
