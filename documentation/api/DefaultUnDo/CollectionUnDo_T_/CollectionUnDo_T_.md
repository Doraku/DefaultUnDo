#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[CollectionUnDo&lt;T&gt;](index.md 'DefaultUnDo\.CollectionUnDo\<T\>')

## CollectionUnDo\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [CollectionUnDo\(object, ICollection&lt;T&gt;, T, bool\)](CollectionUnDo_T_.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool) 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(object, System\.Collections\.Generic\.ICollection\<T\>, T, bool\)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\. |
| [CollectionUnDo\(ICollection&lt;T&gt;, T, bool\)](CollectionUnDo_T_.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool) 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(System\.Collections\.Generic\.ICollection\<T\>, T, bool\)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\. |

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool)'></a>

## CollectionUnDo\(object, ICollection\<T\>, T, bool\) Constructor

Initialise an instance of [CollectionUnDo&lt;T&gt;](index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\.

```csharp
public CollectionUnDo(object? description, System.Collections.Generic.ICollection<T> source, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool).description'></a>

`description` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](index.md#DefaultUnDo.CollectionUnDo_T_.T 'DefaultUnDo\.CollectionUnDo\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') on which to perform operation\.

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.CollectionUnDo_T_.T 'DefaultUnDo\.CollectionUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.ICollection&lt;&gt;\.Add\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.add#system-collections-generic-icollection-1-add(-0) 'System\.Collections\.Generic\.ICollection\`1\.Add\(\`0\)'), false for a [System\.Collections\.Generic\.ICollection&lt;&gt;\.Remove\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.remove#system-collections-generic-icollection-1-remove(-0) 'System\.Collections\.Generic\.ICollection\`1\.Remove\(\`0\)')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool).source 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(object, System\.Collections\.Generic\.ICollection\<T\>, T, bool\)\.source') is null\.

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool)'></a>

## CollectionUnDo\(ICollection\<T\>, T, bool\) Constructor

Initialise an instance of [CollectionUnDo&lt;T&gt;](index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\.

```csharp
public CollectionUnDo(System.Collections.Generic.ICollection<T> source, T item, bool isAdd);
```
#### Parameters

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](index.md#DefaultUnDo.CollectionUnDo_T_.T 'DefaultUnDo\.CollectionUnDo\<T\>\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1 'System\.Collections\.Generic\.ICollection\`1') on which to perform operation\.

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool).item'></a>

`item` [T](index.md#DefaultUnDo.CollectionUnDo_T_.T 'DefaultUnDo\.CollectionUnDo\<T\>\.T')

The argument of the operation\.

<a name='DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool).isAdd'></a>

`isAdd` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

true if the operation is an [System\.Collections\.Generic\.ICollection&lt;&gt;\.Add\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.add#system-collections-generic-icollection-1-add(-0) 'System\.Collections\.Generic\.ICollection\`1\.Add\(\`0\)'), false for a [System\.Collections\.Generic\.ICollection&lt;&gt;\.Remove\(@0\)](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icollection-1.remove#system-collections-generic-icollection-1-remove(-0) 'System\.Collections\.Generic\.ICollection\`1\.Remove\(\`0\)')\.

#### Exceptions

[System\.ArgumentNullException](https://learn.microsoft.com/en-us/dotnet/api/system.argumentnullexception 'System\.ArgumentNullException')  
[source](index.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool).source 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(System\.Collections\.Generic\.ICollection\<T\>, T, bool\)\.source') is null\.