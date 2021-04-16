#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;')
## CollectionUnDo&lt;T&gt;.CollectionUnDo(object, ICollection&lt;T&gt;, T, bool) Constructor
Initialise an instance of [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;').  
```csharp
public CollectionUnDo(object description, System.Collections.Generic.ICollection<T> source, T item, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo_CollectionUnDo_T__CollectionUnDo(object_System_Collections_Generic_ICollection_T__T_bool)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')
  
<a name='DefaultUnDo_CollectionUnDo_T__CollectionUnDo(object_System_Collections_Generic_ICollection_T__T_bool)_source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](CollectionUnDo_T_.md#DefaultUnDo_CollectionUnDo_T__T 'DefaultUnDo.CollectionUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') on which to perform operation.
  
<a name='DefaultUnDo_CollectionUnDo_T__CollectionUnDo(object_System_Collections_Generic_ICollection_T__T_bool)_item'></a>
`item` [T](CollectionUnDo_T_.md#DefaultUnDo_CollectionUnDo_T__T 'DefaultUnDo.CollectionUnDo&lt;T&gt;.T')  
The argument of the operation.
  
<a name='DefaultUnDo_CollectionUnDo_T__CollectionUnDo(object_System_Collections_Generic_ICollection_T__T_bool)_isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is an [System.Collections.Generic.ICollection&lt;&gt;.Add(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Add#System_Collections_Generic_ICollection_1_Add__0_ 'System.Collections.Generic.ICollection`1.Add(`0)'), false for a [System.Collections.Generic.ICollection&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)').
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](CollectionUnDo_T__CollectionUnDo(object_ICollection_T__T_bool).md#DefaultUnDo_CollectionUnDo_T__CollectionUnDo(object_System_Collections_Generic_ICollection_T__T_bool)_source 'DefaultUnDo.CollectionUnDo&lt;T&gt;.CollectionUnDo(object, System.Collections.Generic.ICollection&lt;T&gt;, T, bool).source') is null.
