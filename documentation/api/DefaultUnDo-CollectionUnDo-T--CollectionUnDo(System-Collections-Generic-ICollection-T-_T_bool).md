### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[CollectionUnDo&lt;T&gt;](./DefaultUnDo-CollectionUnDo-T-.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;')
## CollectionUnDo(System.Collections.Generic.ICollection&lt;T&gt;, T, bool) Constructor
Initialise an instance of [CollectionUnDo&lt;T&gt;](./DefaultUnDo-CollectionUnDo-T-.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;').  
```csharp
public CollectionUnDo(System.Collections.Generic.ICollection<T> source, T item, bool isAdd);
```
#### Parameters
<a name='DefaultUnDo-CollectionUnDo-T--CollectionUnDo(System-Collections-Generic-ICollection-T-_T_bool)-source'></a>
`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](./DefaultUnDo-CollectionUnDo-T-.md#DefaultUnDo-CollectionUnDo-T--T 'DefaultUnDo.CollectionUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')  
The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') on which to perform operation.  
  
<a name='DefaultUnDo-CollectionUnDo-T--CollectionUnDo(System-Collections-Generic-ICollection-T-_T_bool)-item'></a>
`item` [T](./DefaultUnDo-CollectionUnDo-T-.md#DefaultUnDo-CollectionUnDo-T--T 'DefaultUnDo.CollectionUnDo&lt;T&gt;.T')  
The argument of the operation.  
  
<a name='DefaultUnDo-CollectionUnDo-T--CollectionUnDo(System-Collections-Generic-ICollection-T-_T_bool)-isAdd'></a>
`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the operation is an [System.Collections.Generic.ICollection&lt;&gt;.Add(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Add#System_Collections_Generic_ICollection_1_Add__0_ 'System.Collections.Generic.ICollection`1.Add(`0)'), false for a [System.Collections.Generic.ICollection&lt;&gt;.Remove(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1.Remove#System_Collections_Generic_ICollection_1_Remove__0_ 'System.Collections.Generic.ICollection`1.Remove(`0)').  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](#DefaultUnDo-CollectionUnDo-T--CollectionUnDo(System-Collections-Generic-ICollection-T-_T_bool)-source 'DefaultUnDo.CollectionUnDo&lt;T&gt;.CollectionUnDo(System.Collections.Generic.ICollection&lt;T&gt;, T, bool).source') is null.  
