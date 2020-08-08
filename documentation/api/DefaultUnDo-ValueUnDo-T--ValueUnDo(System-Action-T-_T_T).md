### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[ValueUnDo&lt;T&gt;](./DefaultUnDo-ValueUnDo-T-.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')
## ValueUnDo(System.Action&lt;T&gt;, T, T) Constructor
Initialises an instance of [ValueUnDo&lt;T&gt;](./DefaultUnDo-ValueUnDo-T-.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').  
```csharp
public ValueUnDo(System.Action<T> setter, T newValue, T oldValue);
```
#### Parameters
<a name='DefaultUnDo-ValueUnDo-T--ValueUnDo(System-Action-T-_T_T)-setter'></a>
`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](./DefaultUnDo-ValueUnDo-T-.md#DefaultUnDo-ValueUnDo-T--T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action called to set the value.  
  
<a name='DefaultUnDo-ValueUnDo-T--ValueUnDo(System-Action-T-_T_T)-newValue'></a>
`newValue` [T](./DefaultUnDo-ValueUnDo-T-.md#DefaultUnDo-ValueUnDo-T--T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')  
The new value.  
  
<a name='DefaultUnDo-ValueUnDo-T--ValueUnDo(System-Action-T-_T_T)-oldValue'></a>
`oldValue` [T](./DefaultUnDo-ValueUnDo-T-.md#DefaultUnDo-ValueUnDo-T--T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')  
The old value.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[setter](#DefaultUnDo-ValueUnDo-T--ValueUnDo(System-Action-T-_T_T)-setter 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(System.Action&lt;T&gt;, T, T).setter') is null.  
