#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoAdd Method

| Overloads | |
| :--- | :--- |
| [DoAdd&lt;T&gt;\(this IUnDoManager, ICollection&lt;T&gt;, T, object\)](DoAdd.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object) 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)') | Adds a value to a [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [DoAdd&lt;T&gt;\(this IUnDoManager, ISet&lt;T&gt;, T, object\)](DoAdd.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object) 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)') | Adds an item from a [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [DoAdd&lt;TKey,TValue&gt;\(this IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object\)](DoAdd.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object) 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)') | Adds a value to a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object)'></a>

## IUnDoManagerExtensions\.DoAdd\<T\>\(this IUnDoManager, ICollection\<T\>, T, object\) Method

Adds a value to a [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).item'></a>

`item` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.T')

The item to add\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.manager') or [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, T, object\)\.source') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object)'></a>

## IUnDoManagerExtensions\.DoAdd\<T\>\(this IUnDoManager, ISet\<T\>, T, object\) Method

Adds an item from a [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static bool DoAdd<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ISet<T> source, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).source'></a>

`source` [System\.Collections\.Generic\.ISet&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')[T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')

The [System\.Collections\.Generic\.ISet&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iset-1 'System\.Collections\.Generic\.ISet\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).item'></a>

`item` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.T')

The item to add\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the operation\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
true if the command has been created, false if not because [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.source') already contained [item](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).item 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.item')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.manager') or [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ISet_T_,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ISet\<T\>, T, object\)\.source') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object)'></a>

## IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this IUnDoManager, IDictionary\<TKey,TValue\>, TKey, TValue, object\) Method

Adds a value to a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void DoAdd<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey'></a>

`TKey`

The type of the key\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue'></a>

`TValue`

The type of the value\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source'></a>

`source` [System\.Collections\.Generic\.IDictionary&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TKey')[,](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TValue](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TValue')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.idictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key'></a>

`key` [TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TKey')

The key to add\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).value'></a>

`value` [TValue](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TValue')

The value to add\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.manager'), [source](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.source') or [key](index.md#DefaultUnDo.IUnDoManagerExtensions.DoAdd_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key 'DefaultUnDo\.IUnDoManagerExtensions\.DoAdd\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.key') is null\.