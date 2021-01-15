### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object) Method
Sets a value as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Action<T> setter, T newValue, T oldValue, object description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-T'></a>
`T`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-setter'></a>
`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') used to change the value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-newValue'></a>
`newValue` [T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')  
The new value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-oldValue'></a>
`oldValue` [T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).T')  
The old value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).manager') or [setter](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_object)-setter 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object).setter') is null.  
