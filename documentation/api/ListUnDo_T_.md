#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## ListUnDo&lt;T&gt; Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') operation.  
```csharp
public sealed class ListUnDo<T> :
DefaultUnDo.IUnDo
```
#### Type parameters
<a name='DefaultUnDo_ListUnDo_T__T'></a>
`T`  
The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ListUnDo&lt;T&gt;  

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  

| Constructors | |
| :--- | :--- |
| [ListUnDo(object, IList&lt;T&gt;, int, T, bool)](ListUnDo_T__ListUnDo(object_IList_T__int_T_bool).md 'DefaultUnDo.ListUnDo&lt;T&gt;.ListUnDo(object, System.Collections.Generic.IList&lt;T&gt;, int, T, bool)') | Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;').<br/> |
| [ListUnDo(IList&lt;T&gt;, int, T, bool)](ListUnDo_T__ListUnDo(IList_T__int_T_bool).md 'DefaultUnDo.ListUnDo&lt;T&gt;.ListUnDo(System.Collections.Generic.IList&lt;T&gt;, int, T, bool)') | Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;').<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IUnDo.Description](ListUnDo_T__DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.ListUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.<br/> |
| [DefaultUnDo.IUnDo.Do()](ListUnDo_T__DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.ListUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Do()') | Does an action.<br/> |
| [DefaultUnDo.IUnDo.Undo()](ListUnDo_T__DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.ListUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.<br/> |
