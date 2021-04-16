#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')
## ValueUnDo&lt;T&gt;.ValueUnDo(object, Action&lt;T&gt;, T, T) Constructor
Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').  
```csharp
public ValueUnDo(object description, System.Action<T> setter, T newValue, T oldValue);
```
#### Parameters
<a name='DefaultUnDo_ValueUnDo_T__ValueUnDo(object_System_Action_T__T_T)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')
  
<a name='DefaultUnDo_ValueUnDo_T__ValueUnDo(object_System_Action_T__T_T)_setter'></a>
`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](ValueUnDo_T_.md#DefaultUnDo_ValueUnDo_T__T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The action called to set the value.
  
<a name='DefaultUnDo_ValueUnDo_T__ValueUnDo(object_System_Action_T__T_T)_newValue'></a>
`newValue` [T](ValueUnDo_T_.md#DefaultUnDo_ValueUnDo_T__T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')  
The new value.
  
<a name='DefaultUnDo_ValueUnDo_T__ValueUnDo(object_System_Action_T__T_T)_oldValue'></a>
`oldValue` [T](ValueUnDo_T_.md#DefaultUnDo_ValueUnDo_T__T 'DefaultUnDo.ValueUnDo&lt;T&gt;.T')  
The old value.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[setter](ValueUnDo_T__ValueUnDo(object_Action_T__T_T).md#DefaultUnDo_ValueUnDo_T__ValueUnDo(object_System_Action_T__T_T)_setter 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(object, System.Action&lt;T&gt;, T, T).setter') is null.
