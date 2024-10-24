#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoInsert\<T\>\(this IUnDoManager, IList\<T\>, int, T, object\) Method

Inserts an item to a [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') at the specified index as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void DoInsert<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](DefaultUnDo/IUnDoManagerExtensions/DoInsert_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoInsert\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).index'></a>

`index` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The zero\-based index at which item should be inserted\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).item'></a>

`item` [T](DefaultUnDo/IUnDoManagerExtensions/DoInsert_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoInsert\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.T')

The item to insert into the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](DefaultUnDo/IUnDoManagerExtensions/DoInsert_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoInsert\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.manager') or [source](DefaultUnDo/IUnDoManagerExtensions/DoInsert_T_(thisIUnDoManager,IList_T_,int,T,object).md#DefaultUnDo.IUnDoManagerExtensions.DoInsert_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoInsert\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.source') is null\.