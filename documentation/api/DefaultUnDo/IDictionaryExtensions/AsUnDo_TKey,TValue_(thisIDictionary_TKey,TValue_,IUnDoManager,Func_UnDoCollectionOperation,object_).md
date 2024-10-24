#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IDictionaryExtensions](index.md 'DefaultUnDo\.IDictionaryExtensions')

## IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this IDictionary\<TKey,TValue\>, IUnDoManager, Func\<UnDoCollectionOperation,object\>\) Method

Wraps an [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') to an UnDo dictionary linked to an [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager') to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public static System.Collections.Generic.IDictionary<TKey,TValue> AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object?>? descriptionFactory=null);
```
#### Type parameters

<a name='DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey'></a>

`TKey`

The type of keys\.

<a name='DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue'></a>

`TValue`

The type of values\.
#### Parameters

<a name='DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source'></a>

`source` [System\.Collections\.Generic\.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TKey](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TValue](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\.

<a name='DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).descriptionFactory'></a>

`descriptionFactory` [System\.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[UnDoCollectionOperation](../UnDoCollectionOperation/index.md 'DefaultUnDo\.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System\.Func\`2')

Factory used to create the description of the generated [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')\.

#### Returns
[System\.Collections\.Generic\.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TKey](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TValue](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')  
A wrapped [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.source') or [manager](DefaultUnDo/IDictionaryExtensions/AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtensions.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager 'DefaultUnDo\.IDictionaryExtensions\.AsUnDo\<TKey,TValue\>\(this System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoCollectionOperation,object\>\)\.manager') is null\.