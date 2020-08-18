### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[IUnDoManagerExtension](./DefaultUnDo-IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')
## IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string) Method
Sets a value as a [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') operation.  
```csharp
public static void Do<T>(this DefaultUnDo.IUnDoManager manager, System.Action<T> setter, T newValue, T oldValue, string description=null);
```
#### Type parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-T'></a>
`T`  
The type of the value.  
  
#### Parameters
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-manager'></a>
`manager` [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager')  
The [IUnDoManager](./DefaultUnDo-IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-setter'></a>
`setter` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')  
The [System.Action&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1') used to change the value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-newValue'></a>
`newValue` [T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string).T')  
The new value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-oldValue'></a>
`oldValue` [T](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-T 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string).T')  
The old value.  
  
<a name='DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-description'></a>
`description` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The description of the operation.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-manager 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string).manager') or [setter](#DefaultUnDo-IUnDoManagerExtension-Do-T-(DefaultUnDo-IUnDoManager_System-Action-T-_T_T_string)-setter 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, string).setter') is null.  
