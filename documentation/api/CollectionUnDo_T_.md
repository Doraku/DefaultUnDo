#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## CollectionUnDo&lt;T&gt; Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') operation.  
```csharp
public sealed class CollectionUnDo<T> :
DefaultUnDo.IUnDo
```
#### Type parameters
<a name='DefaultUnDo_CollectionUnDo_T__T'></a>
`T`  
The type of element in the [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1').
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CollectionUnDo&lt;T&gt;  

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  

| Constructors | |
| :--- | :--- |
| [CollectionUnDo(object, ICollection&lt;T&gt;, T, bool)](CollectionUnDo_T__CollectionUnDo(object_ICollection_T__T_bool).md 'DefaultUnDo.CollectionUnDo&lt;T&gt;.CollectionUnDo(object, System.Collections.Generic.ICollection&lt;T&gt;, T, bool)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;').<br/> |
| [CollectionUnDo(ICollection&lt;T&gt;, T, bool)](CollectionUnDo_T__CollectionUnDo(ICollection_T__T_bool).md 'DefaultUnDo.CollectionUnDo&lt;T&gt;.CollectionUnDo(System.Collections.Generic.ICollection&lt;T&gt;, T, bool)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;').<br/> |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo.IUnDo.Description](CollectionUnDo_T__DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Description') | Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.<br/> |
| [DefaultUnDo.IUnDo.Do()](CollectionUnDo_T__DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.CollectionUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Do()') | Does an action.<br/> |
| [DefaultUnDo.IUnDo.Undo()](CollectionUnDo_T__DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.CollectionUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Undo()') | Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.<br/> |
