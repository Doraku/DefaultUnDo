#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoAdd<TKey,TValue>(this IUnDoManager, IDictionary<TKey,TValue>, TKey, TValue, object) Method

Adds a value to a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static void DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey'></a>

`TKey`

The type of the key.

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue'></a>

`TValue`

The type of the value.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source'></a>

`source` [System.Collections.Generic.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TKey](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')[TValue](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2')

The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key'></a>

`key` [TKey](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).TKey')

The key to add.

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).value'></a>

`value` [TValue](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).TValue')

The value to add.

<a name='DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).manager'), [source](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).source') or [key](IUnDoManagerExtension.DoAdd_TKey,TValue_(thisIUnDoManager,IDictionary_TKey,TValue_,TKey,TValue,object).md#DefaultUnDo.IUnDoManagerExtension.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key 'DefaultUnDo.IUnDoManagerExtension.DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary<TKey,TValue>, TKey, TValue, object).key') is null.