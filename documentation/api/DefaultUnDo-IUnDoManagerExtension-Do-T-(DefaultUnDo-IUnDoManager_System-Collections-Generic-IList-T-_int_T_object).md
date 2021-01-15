### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object) Method
Sets the element at the specified index on a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index of the element to get or set.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-item'></a>
`item` [T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).T')  
The new item.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).manager') or [source](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_object)-source 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object).source') is null.  
