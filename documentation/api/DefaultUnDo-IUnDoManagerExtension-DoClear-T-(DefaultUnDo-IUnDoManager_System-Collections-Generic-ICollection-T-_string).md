### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, string) Method
Clears a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoClear<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, string description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-T 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-manager 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, string).manager') or [source](#DefaultUnDo-IUnDoManagerExtension-DoClear-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ICollection-T-_string)-source 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, string).source') is null.  
