#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoAdd<T>(this IUnDoManager, ICollection<T>, T, object) Method

Adds a value to a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static void DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T'></a>

`T`

The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source'></a>

`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](IUnDoManagerExtension.DoAdd_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo.IUnDoManagerExtension.DoAdd<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item'></a>

`item` [T](IUnDoManagerExtension.DoAdd_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo.IUnDoManagerExtension.DoAdd<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).T')

The item to add.

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoAdd_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).manager') or [source](IUnDoManagerExtension.DoAdd_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo.IUnDoManagerExtension.DoAdd<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).source') is null.