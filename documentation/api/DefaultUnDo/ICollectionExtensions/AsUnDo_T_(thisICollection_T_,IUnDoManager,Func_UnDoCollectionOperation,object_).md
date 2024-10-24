#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[ICollectionExtensions](index.md 'DefaultUnDo\.ICollectionExtensions')

## ICollectionExtensions\.AsUnDo\<T\>\(this ICollection\<T\>, IUnDoManager, Func\<UnDoCollectionOperation,object\>\) Method

Wraps an [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1') to an UnDo collection linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static System.Collections.Generic.ICollection<T> AsUnDo<T>(this System.Collections.Generic.ICollection<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object?>? descriptionFactory=null);
```
#### Type parameters

<a name='DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.
#### Parameters

<a name='DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](DefaultUnDo/ICollectionExtensions/AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.ICollectionExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ICollection\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

<a name='DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[UnDoCollectionOperation](../UnDoCollectionOperation/index.md 'DefaultUnDo\.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Returns
[System\.Collections\.Generic\.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](DefaultUnDo/ICollectionExtensions/AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.ICollectionExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ICollection\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')  
A wrapped [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](DefaultUnDo/ICollectionExtensions/AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source 'DefaultUnDo\.ICollectionExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ICollection\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.source') or [manager](DefaultUnDo/ICollectionExtensions/AsUnDo_T_(thisICollection_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ICollectionExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ICollection_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager 'DefaultUnDo\.ICollectionExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ICollection\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.manager') is null\.