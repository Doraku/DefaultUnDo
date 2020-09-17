### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ListUnDo&lt;T&gt;](./DefaultUnDo-ListUnDo-T-.md 'DefaultUnDo.ListUnDo&lt;T&gt;')
## ListUnDo(string, System.Collections.Generic.IList&lt;T&gt;, int, T, bool) Constructor
Initialises an instance of [ListUnDo&lt;T&gt;](./DefaultUnDo-ListUnDo-T-.md 'DefaultUnDo.ListUnDo&lt;T&gt;').  
```csharp
public ListUnDo(string description, System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of this [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
  
<a name='DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](./DefaultUnDo-ListUnDo-T-.md#DefaultUnDo-ListUnDo-T--T 'DefaultUnDo.ListUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') on which the operation is performed.  
  
<a name='DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-index'></a>
`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The index of the operation.  
  
<a name='DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-item'></a>
`item` [T](./DefaultUnDo-ListUnDo-T-.md#DefaultUnDo-ListUnDo-T--T 'DefaultUnDo.ListUnDo&lt;T&gt;.T')  
The argument of the operation.  
  
<a name='DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is an [System.Collections.Generic.IList&lt;&gt;.IndexOf(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.IndexOf#System_Collections_Generic_IList_1_IndexOf__0_ 'System.Collections.Generic.IList`1.IndexOf(`0)'), else false for a [System.Collections.Generic.IList&lt;&gt;.RemoveAt(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System.Collections.Generic.IList`1.RemoveAt(System.Int32)').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-ListUnDo-T--ListUnDo(string_System-Collections-Generic-IList-T-_int_T_bool)-source 'DefaultUnDo.ListUnDo&lt;T&gt;.ListUnDo(string, System.Collections.Generic.IList&lt;T&gt;, int, T, bool).source') is null.  
