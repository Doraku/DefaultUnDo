#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;')
## ListUnDo&lt;T&gt;.ListUnDo(object, IList&lt;T&gt;, int, T, bool) Constructor
Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;').  
```csharp
public ListUnDo(object description, System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')
  
<a name='DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](ListUnDo_T_.md#DefaultUnDo_ListUnDo_T__T 'DefaultUnDo.ListUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') on which the operation is performed.
  
<a name='DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the operation.
  
<a name='DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_item'></a>
`item` [T](ListUnDo_T_.md#DefaultUnDo_ListUnDo_T__T 'DefaultUnDo.ListUnDo&lt;T&gt;.T')  
The argument of the operation.
  
<a name='DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is an [System.Collections.Generic.IList&lt;&gt;.IndexOf(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.IndexOf#System_Collections_Generic_IList_1_IndexOf__0_ 'System.Collections.Generic.IList`1.IndexOf(`0)'), else false for a [System.Collections.Generic.IList&lt;&gt;.RemoveAt(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System.Collections.Generic.IList`1.RemoveAt(System.Int32)').
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](ListUnDo_T__ListUnDo(object_IList_T__int_T_bool).md#DefaultUnDo_ListUnDo_T__ListUnDo(object_System_Collections_Generic_IList_T__int_T_bool)_source 'DefaultUnDo.ListUnDo&lt;T&gt;.ListUnDo(object, System.Collections.Generic.IList&lt;T&gt;, int, T, bool).source') is null.
