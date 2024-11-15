#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.Do Method

| Overloads | |
| :--- | :--- |
| [Do\(this IUnDoManager, Action, Action, object\)](Do.md#DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object) 'DefaultUnDo\.IUnDoManagerExtensions\.Do\(this DefaultUnDo\.IUnDoManager, System\.Action, System\.Action, object\)') | Does a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation on the manager with the specified doAction and undoAction\. |
| [Do&lt;T&gt;\(this IUnDoManager, Action&lt;T&gt;, T, T, object\)](Do.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object) 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)') | Sets a value as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [Do&lt;T&gt;\(this IUnDoManager, IList&lt;T&gt;, int, T, object\)](Do.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object) 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)') | Sets the element at the specified index on a [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [Do&lt;TKey,TValue&gt;\(this IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object\)](Do.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object) 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)') | Sets the element with the specified key on a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |

<a name='DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object)'></a>

## IUnDoManagerExtensions\.Do\(this IUnDoManager, Action, Action, object\) Method

Does a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation on the manager with the specified doAction and undoAction\.

```csharp
public static void Do(this DefaultUnDo.IUnDoManager manager, System.Action? doAction, System.Action? undoAction, object? description=null);
```
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).doAction'></a>

`doAction` [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action')

The [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action') performed by [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).undoAction'></a>

`undoAction` [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action')

The [System\.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System\.Action') performed by the [Undo\(\)](../IUnDo/Undo().md 'DefaultUnDo\.IUnDo\.Undo\(\)')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.Do(thisDefaultUnDo.IUnDoManager,System.Action,System.Action,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.Do\(this DefaultUnDo\.IUnDoManager, System\.Action, System\.Action, object\)\.manager') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object)'></a>

## IUnDoManagerExtensions\.Do\<T\>\(this IUnDoManager, Action\<T\>, T, T, object\) Method

Sets a value as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Action<T> setter, T newValue, T oldValue, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T'></a>

`T`

The type of the value\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).setter'></a>

`setter` [System\.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')[T](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')

The [System\.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1') used to change the value\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).newValue'></a>

`newValue` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)\.T')

The new value\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).oldValue'></a>

`oldValue` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)\.T')

The old value\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)\.manager') or [setter](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).setter 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Action\<T\>, T, T, object\)\.setter') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object)'></a>

## IUnDoManagerExtensions\.Do\<T\>\(this IUnDoManager, IList\<T\>, int, T, object\) Method

Sets the element at the specified index on a [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IList<T> source, int index, T item, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).index'></a>

`index` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The zero\-based index of the element to get or set\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).item'></a>

`item` [T](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.T')

The new item\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.manager') or [source](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IList_T_,int,T,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IList\<T\>, int, T, object\)\.source') is null\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object)'></a>

## IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this IUnDoManager, IDictionary\<TKey,TValue\>, TKey, TValue, object\) Method

Sets the element with the specified key on a [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void Do<TKey,TValue>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.IDictionary<TKey,TValue> source, TKey key, TValue value, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey'></a>

`TKey`

The type of the key\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue'></a>

`TValue`

The type of the value\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source'></a>

`source` [System\.Collections\.Generic\.IDictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TKey')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')[TValue](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')

The [System\.Collections\.Generic\.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System\.Collections\.Generic\.IDictionary\`2')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key'></a>

`key` [TKey](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TKey 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TKey')

The key to set\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).value'></a>

`value` [TValue](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).TValue 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.TValue')

The value to add\.

<a name='DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.manager'), [source](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.source') or [key](index.md#DefaultUnDo.IUnDoManagerExtensions.Do_TKey,TValue_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.IDictionary_TKey,TValue_,TKey,TValue,object).key 'DefaultUnDo\.IUnDoManagerExtensions\.Do\<TKey,TValue\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.IDictionary\<TKey,TValue\>, TKey, TValue, object\)\.key') is null\.