### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, string) Method
Inserts an item to a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') at the specified index as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void DoInsert<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, string description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-T 'DefaultUnDo.IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index at which item should be inserted.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-item'></a>
`item` [T](#DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-T 'DefaultUnDo.IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, string).T')  
The item to insert into the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-manager 'DefaultUnDo.IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, string).manager') or [source](#DefaultUnDo-IUnDoManagerExtension-DoInsert-T-(DefaultUnDo-IUnDoManager_System-Collections-Generic-IList-T-_int_T_string)-source 'DefaultUnDo.IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, string).source') is null.  
