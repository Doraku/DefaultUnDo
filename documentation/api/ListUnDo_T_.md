#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## ListUnDo<T> Class

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') operation.

```csharp
public sealed class ListUnDo<T> :
DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.ListUnDo_T_.T'></a>

`T`

The type of element in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ListUnDo<T>

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

| Constructors | |
| :--- | :--- |
| [ListUnDo(object, IList&lt;T&gt;, int, T, bool)](ListUnDo_T_.ListUnDo(object,IList_T_,int,T,bool).md 'DefaultUnDo.ListUnDo<T>.ListUnDo(object, System.Collections.Generic.IList<T>, int, T, bool)') | Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo<T>'). |
| [ListUnDo(IList&lt;T&gt;, int, T, bool)](ListUnDo_T_.ListUnDo(IList_T_,int,T,bool).md 'DefaultUnDo.ListUnDo<T>.ListUnDo(System.Collections.Generic.IList<T>, int, T, bool)') | Initialises an instance of [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo<T>'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IUnDo.Description](ListUnDo_T_.DefaultUnDo.IUnDo.Description.md 'DefaultUnDo.ListUnDo<T>.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform. |
| [DefaultUnDo.IUnDo.Do()](ListUnDo_T_.DefaultUnDo.IUnDo.Do().md 'DefaultUnDo.ListUnDo<T>.DefaultUnDo.IUnDo.Do()') | Does an action. |
| [DefaultUnDo.IUnDo.Undo()](ListUnDo_T_.DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo.ListUnDo<T>.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()') action. |
