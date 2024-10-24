#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoRemoveAt\<T\>\(this IUnDoManager, IList\<T\>, int, object\) Method

Removes an item from a [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') at the specified index as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void DoRemoveAt<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](DefaultUnDo/IUnDoManagerExtensions/DoRemoveAt_T_(thisIUnDoManager,IList_T_,int,object).md#DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemoveAt\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, object\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).index'></a>

`index` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The zero\-based index at which item should be removed\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](DefaultUnDo/IUnDoManagerExtensions/DoRemoveAt_T_(thisIUnDoManager,IList_T_,int,object).md#DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemoveAt\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, object\)\.manager') or [source](DefaultUnDo/IUnDoManagerExtensions/DoRemoveAt_T_(thisIUnDoManager,IList_T_,int,object).md#DefaultUnDo.IUnDoManagerExtensions.DoRemoveAt_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemoveAt\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, object\)\.source') is null\.