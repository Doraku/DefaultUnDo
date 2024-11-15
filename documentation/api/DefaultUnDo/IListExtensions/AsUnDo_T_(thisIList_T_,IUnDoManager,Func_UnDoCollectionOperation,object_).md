#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IListExtensions](index.md 'DefaultUnDo\.IListExtensions')

## IListExtensions\.AsUnDo\<T\>\(this IList\<T\>, IUnDoManager, Func\<UnDoCollectionOperation,object\>\) Method

Wraps an [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') to an UnDo list linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static System.Collections.Generic.IList<T> AsUnDo<T>(this System.Collections.Generic.IList<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object?>? descriptionFactory=null);
```
#### Type parameters

<a name='DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.
#### Parameters

<a name='DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](AsUnDo_T_(thisIList_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.IListExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.IList\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

<a name='DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[UnDoCollectionOperation](../UnDoCollectionOperation/index.md 'DefaultUnDo\.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Returns
[System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](AsUnDo_T_(thisIList_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.IListExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.IList\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')  
A wrapped [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](AsUnDo_T_(thisIList_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source 'DefaultUnDo\.IListExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.IList\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.source') or [manager](AsUnDo_T_(thisIList_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IListExtensions.AsUnDo_T_(thisSystem.Collections.Generic.IList_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager 'DefaultUnDo\.IListExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.IList\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.manager') is null\.