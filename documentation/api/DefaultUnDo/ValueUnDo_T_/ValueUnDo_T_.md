#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ValueUnDo\<T\>')

## ValueUnDo\<T\> Constructors

| Overloads | |
| :--- | :--- |
| [ValueUnDo\(object, Action&lt;T&gt;, T, T\)](DefaultUnDo/ValueUnDo_T_/ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T) 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(object, System\.Action\<T\>, T, T\)') | Initialises an instance of [ValueUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ValueUnDo\<T\>')\. |
| [ValueUnDo\(Action&lt;T&gt;, T, T\)](DefaultUnDo/ValueUnDo_T_/ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T) 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(System\.Action\<T\>, T, T\)') | Initialises an instance of [ValueUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ValueUnDo\<T\>')\. |

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T)'></a>

## ValueUnDo\(object, Action\<T\>, T, T\) Constructor

Initialises an instance of [ValueUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ValueUnDo\<T\>')\.

```csharp
public ValueUnDo(object? description, System.Action<T> setter, T newValue, T oldValue);
```
#### Parameters

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).setter'></a>

`setter` [System\.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')[T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')

The action called to set the value\.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).newValue'></a>

`newValue` [T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')

The new value\.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).oldValue'></a>

`oldValue` [T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')

The old value\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[setter](index.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).setter 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(object, System\.Action\<T\>, T, T\)\.setter') is null\.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T)'></a>

## ValueUnDo\(Action\<T\>, T, T\) Constructor

Initialises an instance of [ValueUnDo&lt;T&gt;](index.md 'DefaultUnDo\.ValueUnDo\<T\>')\.

```csharp
public ValueUnDo(System.Action<T> setter, T newValue, T oldValue);
```
#### Parameters

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T).setter'></a>

`setter` [System\.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')[T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System\.Action\`1')

The action called to set the value\.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T).newValue'></a>

`newValue` [T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')

The new value\.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T).oldValue'></a>

`oldValue` [T](index.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo\.ValueUnDo\<T\>\.T')

The old value\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[setter](index.md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(System.Action_T_,T,T).setter 'DefaultUnDo\.ValueUnDo\<T\>\.ValueUnDo\(System\.Action\<T\>, T, T\)\.setter') is null\.