#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo<T>')

## ListUnDo(IList<T>, int, T, bool) Constructor

Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo<T>').

```csharp
public ListUnDo(System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source'></a>

`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo.ListUnDo<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') on which the operation is performed.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The index of the operation.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).item'></a>

`item` [T](ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo.ListUnDo<T>.T')

The argument of the operation.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).isAdd'></a>

`isAdd` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

true if the operation is an [System.Collections.Generic.IList&lt;&gt;.IndexOf(@0)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.IndexOf#System_Collections_Generic_IList_1_IndexOf__0_ 'System.Collections.Generic.IList`1.IndexOf(`0)'), else false for a [System.Collections.Generic.IList&lt;&gt;.RemoveAt(System.Int32)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System.Collections.Generic.IList`1.RemoveAt(System.Int32)').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](ListUnDo_T_.ListUnDo(IList_T_,int,T,bool).md#DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source 'DefaultUnDo.ListUnDo<T>.ListUnDo(System.Collections.Generic.IList<T>, int, T, bool).source') is null.