#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

## IUnDoManagerExtension.DoClear<T>(this IUnDoManager, ICollection<T>, object) Method

Clears a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.

```csharp
public static void DoClear<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).T'></a>

`T`

The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).manager'></a>

`manager` [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

The [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').

<a name='DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).source'></a>

`source` [System.Collections.Generic.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')[T](IUnDoManagerExtension.DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).T 'DefaultUnDo.IUnDoManagerExtension.DoClear<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, object).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1')

The [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

<a name='DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).description'></a>

`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the operation.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[manager](IUnDoManagerExtension.DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).manager 'DefaultUnDo.IUnDoManagerExtension.DoClear<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, object).manager') or [source](IUnDoManagerExtension.DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtension.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).source 'DefaultUnDo.IUnDoManagerExtension.DoClear<T>(this DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection<T>, object).source') is null.