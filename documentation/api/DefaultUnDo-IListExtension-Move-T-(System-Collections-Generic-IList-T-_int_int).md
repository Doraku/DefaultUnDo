### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IListExtension](./DefaultUnDo-IListExtension.md 'DefaultUnDo.IListExtension')
## IListExtension.Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int) Method
Moves the item at the specified index to a new location in the collection.  
```csharp
public static void Move<T>(this System.Collections.Generic.IList<T> source, int oldIndex, int newIndex);
```
#### Type parameters
<a name='DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int)-T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').  
  
#### Parameters
<a name='DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int)-source'></a>
`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](#DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int)-T 'DefaultUnDo.IListExtension.Move&lt;T&gt;(System.Collections.Generic.IList&lt;T&gt;, int, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')  
The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') on which to perform the move.  
  
<a name='DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int)-oldIndex'></a>
`oldIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index specifying the location of the item to be moved.  
  
<a name='DefaultUnDo-IListExtension-Move-T-(System-Collections-Generic-IList-T-_int_int)-newIndex'></a>
`newIndex` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The zero-based index specifying the new location of the item.  
  
