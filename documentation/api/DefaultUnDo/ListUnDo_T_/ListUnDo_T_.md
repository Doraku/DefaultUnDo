#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')

## ListUnDo\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [ListUnDo\(object, IList&lt;T&gt;, int, T, bool\)](DefaultUnDo/ListUnDo_T_/ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool) 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(object, System\.Collections\.Generic\.IList\<T\>, int, T, bool\)') | Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\. |
| [ListUnDo\(IList&lt;T&gt;, int, T, bool\)](DefaultUnDo/ListUnDo_T_/ListUnDo_T_.md#DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool) 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(System\.Collections\.Generic\.IList\<T\>, int, T, bool\)') | Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\. |

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool)'></a>

## ListUnDo\(object, IList\<T\>, int, T, bool\) Constructor

Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\.

```csharp
public ListUnDo(object? description, System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') on which the operation is performed\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).index'></a>

`index` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The index of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.IList&lt;&gt;\.IndexOf\(@0\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.IndexOf#System_Collections_Generic_IList_1_IndexOf__0_ 'System\.Collections\.Generic\.IList\`1\.IndexOf\(\`0\)'), else false for a [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.ListUnDo_T_.ListUnDo(object,System.Collections.Generic.IList_T_,int,T,bool).source 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(object, System\.Collections\.Generic\.IList\<T\>, int, T, bool\)\.source') is null\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool)'></a>

## ListUnDo\(IList\<T\>, int, T, bool\) Constructor

Initialises an instance of [ListUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ListUnDo\<T\>')\.

```csharp
public ListUnDo(System.Collections.Generic.IList<T> source, int index, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source'></a>

`source` [System\.Collections\.Generic\.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')[T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1')

The [System\.Collections\.Generic\.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System\.Collections\.Generic\.IList\`1') on which the operation is performed\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).index'></a>

`index` [System\.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System\.Int32')

The index of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.ListUnDo_T_.T 'DefaultUnDo\.ListUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.IList&lt;&gt;\.IndexOf\(@0\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.IndexOf#System_Collections_Generic_IList_1_IndexOf__0_ 'System\.Collections\.Generic\.IList\`1\.IndexOf\(\`0\)'), else false for a [System\.Collections\.Generic\.IList&lt;&gt;\.RemoveAt\(System\.Int32\)](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1.RemoveAt#System_Collections_Generic_IList_1_RemoveAt_System_Int32_ 'System\.Collections\.Generic\.IList\`1\.RemoveAt\(System\.Int32\)')\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.ListUnDo_T_.ListUnDo(System.Collections.Generic.IList_T_,int,T,bool).source 'DefaultUnDo\.ListUnDo\<T\>\.ListUnDo\(System\.Collections\.Generic\.IList\<T\>, int, T, bool\)\.source') is null\.