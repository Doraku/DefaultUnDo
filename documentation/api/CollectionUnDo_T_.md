#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## CollectionUnDo<T> Class

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') operation.

```csharp
public sealed class CollectionUnDo<T> :
DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.CollectionUnDo_T_.T'></a>

`T`

The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CollectionUnDo<T>

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

| Constructors | |
| :--- | :--- |
| [CollectionUnDo(object, ICollection&lt;T&gt;, T, bool)](CollectionUnDo_T_.CollectionUnDo(object,ICollection_T_,T,bool).md 'DefaultUnDo.CollectionUnDo<T>.CollectionUnDo(object, System.Collections.Generic.ICollection<T>, T, bool)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo<T>'). |
| [CollectionUnDo(ICollection&lt;T&gt;, T, bool)](CollectionUnDo_T_.CollectionUnDo(ICollection_T_,T,bool).md 'DefaultUnDo.CollectionUnDo<T>.CollectionUnDo(System.Collections.Generic.ICollection<T>, T, bool)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo<T>'). |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IUnDo.Description](CollectionUnDo_T_.DefaultUnDo.IUnDo.Description.md 'DefaultUnDo.CollectionUnDo<T>.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform. |
| [DefaultUnDo.IUnDo.Do()](CollectionUnDo_T_.DefaultUnDo.IUnDo.Do().md 'DefaultUnDo.CollectionUnDo<T>.DefaultUnDo.IUnDo.Do()') | Does an action. |
| [DefaultUnDo.IUnDo.Undo()](CollectionUnDo_T_.DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo.CollectionUnDo<T>.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo.Do().md 'DefaultUnDo.IUnDo.Do()') action. |
