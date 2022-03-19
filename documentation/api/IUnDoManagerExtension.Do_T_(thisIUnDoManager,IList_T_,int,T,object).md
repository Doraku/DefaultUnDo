#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.Do<T>(this IUnDoManager, IList<T>, int, T, object) Method

Sets the element at the specified index on a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T'></a>

`T`

The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source'></a>

`source` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[T](IUnDoManagerExtension.Do_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IList<T>, int, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).index'></a>

`index` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The zero-based index of the element to get or set.

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).item'></a>

`item` [T](IUnDoManagerExtension.Do_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IList<T>, int, T, object).T')

The new item.

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.Do_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IList<T>, int, T, object).manager') or [source](IUnDoManagerExtension.Do_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IList<T>, int, T, object).source') is null.