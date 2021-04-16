#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;T&gt;(IUnDoManager, Action&lt;T&gt;, T, T, object) Method
Sets a value as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Action<T> setter, T newValue, T oldValue, object description=null);
```
#### Type parameters
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_T'></a>
`T`  
The type of the value.
  
#### Parameters
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_manager'></a>
`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_setter'></a>
`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') used to change the value.
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_newValue'></a>
`newValue` [T](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')  
The new value.
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_oldValue'></a>
`oldValue` [T](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')  
The old value.
  
<a name='DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).manager') or [setter](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md#DefaultUnDo_IUnDoManagerExtension_Do_T_(DefaultUnDo_IUnDoManager_System_Action_T__T_T_object)_setter 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).setter') is null.
