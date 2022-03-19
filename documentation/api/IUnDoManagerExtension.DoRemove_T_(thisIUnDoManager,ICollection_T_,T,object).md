#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoRemove<T>(this IUnDoManager, ICollection<T>, T, object) Method

Removes an item from a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static bool DoRemove<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T'></a>

`T`

The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source'></a>

`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item'></a>

`item` [T](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).T')

The item to remove.

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).source') did not contained [item](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).item').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).manager') or [source](IUnDoManagerExtension.DoRemove_T_(thisIUnDoManager,ICollection_T_,T,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo.IUnDoManagerExtension.DoRemove<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, T, object).source') is null.