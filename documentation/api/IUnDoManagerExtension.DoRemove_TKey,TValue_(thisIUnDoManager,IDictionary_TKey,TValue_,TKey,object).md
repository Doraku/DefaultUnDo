#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoRemove<TKey,TValue>(this IUnDoManager, IDictionary<TKey,TValue>, TKey, object) Method

Removes the item with the specified key from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static bool DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey'></a>

`TKey`

The type of the key.

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source'></a>

`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TValue 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key'></a>

`key` [TKey](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).TKey')

The key to remove.

<a name='DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if the command has been created, false if not because [source](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).source') did not contained [key](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).key').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).manager'), [source](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).source') or [key](IUnDoManagerExtension.DoRemove_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,object).md#DefaultUnDo.IUnDoManagerExtension.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key 'DefaultUnDo.IUnDoManagerExtension.DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, object).key') is null.