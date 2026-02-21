#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[ISetExtensions](index.md 'DefaultUnDo\.ISetExtensions')

## ISetExtensions\.AsUnDo\<T\>\(this ISet\<T\>, IUnDoManager, Func\<UnDoCollectionOperation,object\>\) Method

Wraps an [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1') to an UnDo set linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static System.Collections.Generic.ISet<T> AsUnDo<T>(this System.Collections.Generic.ISet<T> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object?>? descriptionFactory=null);
```
#### Type parameters

<a name='DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')\.
#### Parameters

<a name='DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source'></a>

`source` [System\.Collections\.Generic\.ISet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')[T](AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.ISetExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ISet\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')

The [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')\.

<a name='DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[UnDoCollectionOperation](../UnDoCollectionOperation/index.md 'DefaultUnDo\.UnDoCollectionOperation')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Returns
[System\.Collections\.Generic\.ISet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')[T](AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).T 'DefaultUnDo\.ISetExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ISet\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')  
A wrapped [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source 'DefaultUnDo\.ISetExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ISet\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.source') or [manager](AsUnDo_T_(thisISet_T_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.ISetExtensions.AsUnDo_T_(thisSystem.Collections.Generic.ISet_T_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager 'DefaultUnDo\.ISetExtensions\.AsUnDo\<T\>\(this System\.Collections\.Generic\.ISet\<T\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.manager') is null\.