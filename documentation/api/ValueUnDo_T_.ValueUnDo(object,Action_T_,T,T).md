#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>')

## ValueUnDo(object, Action<T>, T, T) Constructor

Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>').

```csharp
public ValueUnDo(object? description, System.Action<T> setter, T newValue, T oldValue);
```
#### Parameters

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).setter'></a>

`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo.ValueUnDo<T>.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action called to set the value.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).newValue'></a>

`newValue` [T](ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo.ValueUnDo<T>.T')

The new value.

<a name='DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).oldValue'></a>

`oldValue` [T](ValueUnDo_T_.md#DefaultUnDo.ValueUnDo_T_.T 'DefaultUnDo.ValueUnDo<T>.T')

The old value.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[setter](ValueUnDo_T_.ValueUnDo(object,Action_T_,T,T).md#DefaultUnDo.ValueUnDo_T_.ValueUnDo(object,System.Action_T_,T,T).setter 'DefaultUnDo.ValueUnDo<T>.ValueUnDo(object, System.Action<T>, T, T).setter') is null.