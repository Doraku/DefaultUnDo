#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.Do<T>(this IUnDoManager, Action<T>, T, T, object) Method

Sets a value as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Action<T> setter, T newValue, T oldValue, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T'></a>

`T`

The type of the value.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).setter'></a>

`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](IUnDoManagerExtension.Do_T_(thisIUnDoManager,Action_T_,T,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Action<T>, T, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') used to change the value.

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).newValue'></a>

`newValue` [T](IUnDoManagerExtension.Do_T_(thisIUnDoManager,Action_T_,T,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Action<T>, T, T, object).T')

The new value.

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).oldValue'></a>

`oldValue` [T](IUnDoManagerExtension.Do_T_(thisIUnDoManager,Action_T_,T,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).T 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Action<T>, T, T, object).T')

The old value.

<a name='DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.Do_T_(thisIUnDoManager,Action_T_,T,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).manager 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Action<T>, T, T, object).manager') or [setter](IUnDoManagerExtension.Do_T_(thisIUnDoManager,Action_T_,T,T,object).md#DefaultUnDo.IUnDoManagerExtension.Do_T_(thisDefaultUnDo.IUnDoManager,System.Action_T_,T,T,object).setter 'DefaultUnDo.IUnDoManagerExtension.Do<T>(this DefaultUnDo.IUnDoManager, System.Action<T>, T, T, object).setter') is null.