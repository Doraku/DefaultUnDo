#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[IUnDoManagerExtensions](index.md 'DefaultUnDo\.IUnDoManagerExtensions')

## IUnDoManagerExtensions\.DoClear\<T\>\(this IUnDoManager, ICollection\<T\>, object\) Method

Clears a [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1') as a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\.

```csharp
public static void DoClear<T>(this DefaultUnDo.IUnDoManager manager, System.Collections.Generic.ICollection<T> source, object? description=null);
```
#### Type parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.
#### Parameters

<a name='DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).manager'></a>

`manager` [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')

The [IUnDoManager](../IUnDoManager/index.md 'DefaultUnDo\.IUnDoManager')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).source'></a>

`source` [System\.Collections\.Generic\.ICollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')[T](DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).T 'DefaultUnDo\.IUnDoManagerExtensions\.DoClear\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, object\)\.T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')

The [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

<a name='DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).description'></a>

`description` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the operation\.

#### Exceptions

[System\.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System\.ArgumentNullException')  
[manager](DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).manager 'DefaultUnDo\.IUnDoManagerExtensions\.DoClear\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, object\)\.manager') or [source](DoClear_T_(thisIUnDoManager,ICollection_T_,object).md#DefaultUnDo.IUnDoManagerExtensions.DoClear_T_(thisDefaultUnDo.IUnDoManager,System.Collections.Generic.ICollection_T_,object).source 'DefaultUnDo\.IUnDoManagerExtensions\.DoClear\<T\>\(this DefaultUnDo\.IUnDoManager, System\.Collections\.Generic\.ICollection\<T\>, object\)\.source') is null\.