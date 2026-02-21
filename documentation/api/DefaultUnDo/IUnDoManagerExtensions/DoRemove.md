#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoRemove Method

| Overloads | |
| :--- | :--- |
| [DoRemove&lt;T&gt;\(this IUnDoManager, ICollection&lt;T&gt;, T, object\)](DoRemove.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object) 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)') | Removes an item from a [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [DoRemove&lt;TKey,TValue&gt;\(this IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, object\)](DoRemove.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object) 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)') | Removes the item with the specified key from a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object)'></a>

## IUnDoManagerExtensions\.DoRemove\<T\>\(this IUnDoManager, ICollection\<T\>, T, object\) Method

Removes an item from a [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static bool DoRemove<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item'></a>

`item` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.T')

The item to remove\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the command has been created, false if not because [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.source') did not contained [item](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.item')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.manager') or [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.source') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object)'></a>

## IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this IUnDoManager, IDictionary\<TKey,TValue\>, TKey, object\) Method

Removes the item with the specified key from a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static bool DoRemove<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey'></a>

`TKey`

The type of the key\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TValue'></a>

`TValue`

The type of the value\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source'></a>

`source` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.TKey')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TValue](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TValue 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key'></a>

`key` [TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.TKey')

The key to remove\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the command has been created, false if not because [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.source') did not contained [key](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.key')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.manager'), [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.source') or [key](index.md#DefaultUnDo.IUnDoManagerExtensions.DoRemove_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,object).key 'DefaultUnDo\.IUnDoManagerExtensions\.DoRemove\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, object\)\.key') is null\.