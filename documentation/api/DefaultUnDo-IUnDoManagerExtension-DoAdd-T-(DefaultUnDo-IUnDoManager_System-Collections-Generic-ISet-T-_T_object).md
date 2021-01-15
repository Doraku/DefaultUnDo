### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object) Method
Adds an item from a [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static bool DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ISet<T> source, T item, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-source'></a>
`source` [System.Collections.Generic.ISet&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')[T](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1')  
The [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-item'></a>
`item` [T](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).T')  
The item to add.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).source') already contained [item](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-item 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).item').  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).manager') or [source](#DefaultUnDo-IUnDoManagerExtension-DoAdd-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-ISet-T-_T_object)-source 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object).source') is null.  
