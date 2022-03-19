#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IDictionaryExtension](IDictionaryExtension.md 'DefaultUnDo.IDictionaryExtension')

## IDictionaryExtension.AsUnDo<TKey,TValue>(this IDictionary<TKey,TValue>, IUnDoManager, Func<UnDoCollectionOperation,object>) Method

Wraps an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

```csharp
public static System.Collections.Generic.IDictionary<TKey,TValue> AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue> source, DefaultUnDo.IUnDoManager manager, System.Func<DefaultUnDo.UnDoCollectionOperation,object?>? descriptionFactory=null);
```
#### Type parameters

<a name='DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey'></a>

`TKey`

The type of keys.

<a name='DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue'></a>

`TValue`

The type of values.
#### Parameters

<a name='DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source'></a>

`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

<a name='DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).descriptionFactory'></a>

`descriptionFactory` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Factory used to create the description of the generated [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').

#### Returns
[System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TKey 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).TValue 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')  
A wrapped [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[source](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).source 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).source') or [manager](IDictionaryExtension.AsUnDo_TKey,TValue_(thisIDictionary_TKey,TValue_,IUnDoManager,Func_UnDoCollectionOperation,object_).md#DefaultUnDo.IDictionaryExtension.AsUnDo_TKey,TValue_(thisSystem.Collections.Generic.IDictionary_TKey,TValue_,DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoCollectionOperation,object_).manager 'DefaultUnDo.IDictionaryExtension.AsUnDo<TKey,TValue>(this System.Collections.Generic.IDictionary<TKey,TValue>, DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoCollectionOperation,object>).manager') is null.