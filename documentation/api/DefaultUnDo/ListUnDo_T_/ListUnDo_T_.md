#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')

## ListUnDo\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [ListUnDo\(object, IList&lt;T&gt;, int, T, bool\)](ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool) 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(object, System\.Collections\.Generic\.IList\<T\>, int, T, bool\)') | Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\. |
| [ListUnDo\(IList&lt;T&gt;, int, T, bool\)](ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool) 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(System\.Collections\.Generic\.IList\<T\>, int, T, bool\)') | Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\. |

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool)'></a>

## ListUnDo\(object, IList\<T\>, int, T, bool\) Constructor

Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\.

```csharp
public ListUnDo(object? description, System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1') on which the operation is performed\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.IList&lt;&gt;\.IndexOf\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.indexof#system-collections-generic-ilist-1-indexof(-0) 'System\.Collections\.Generic\.IList\`1\.IndexOf\(\`0\)'), else false for a [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.removeat#system-collections-generic-ilist-1-removeat(system-int32) 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).source 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(object, System\.Collections\.Generic\.IList\<T\>, int, T, bool\)\.source') is null\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool)'></a>

## ListUnDo\(IList\<T\>, int, T, bool\) Constructor

Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\.

```csharp
public ListUnDo(System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')[T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1 'System\.Collections\.Generic\.IList\`1') on which the operation is performed\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).index'></a>

`index` [System\.Int32](https://learn.microsoft.com/en-us/dotnet/api/system.int32 'System\.Int32')

The index of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.IList&lt;&gt;\.IndexOf\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.indexof#system-collections-generic-ilist-1-indexof(-0) 'System\.Collections\.Generic\.IList\`1\.IndexOf\(\`0\)'), else false for a [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ilist-1.removeat#system-collections-generic-ilist-1-removeat(system-int32) 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(System\.Collections\.Generic\.IList\<T\>, int, T, bool\)\.source') is null\.