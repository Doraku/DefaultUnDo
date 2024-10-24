#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## CollectionUnDo\<T\> Class

Provides an implementation of the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') interface for [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1') operation\.

```csharp
public sealed class CollectionUnDo<T> : DefaultUnDo.IUnDo
```
#### Type parameters

<a name='DefaultUnDo.CollectionUnDo_T_.T'></a>

`T`

The type of element in the [System\.Collections\.Generic\.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System\.Collections\.Generic\.ICollection\`1')\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; CollectionUnDo<T>

Implements [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo')

| Constructors | |
| :--- | :--- |
| [CollectionUnDo\(object, ICollection&lt;T&gt;, T, bool\)](CollectionUnDo_T_.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(object,System.Collections.Generic.ICollection_T_,T,bool) 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(object, System\.Collections\.Generic\.ICollection\<T\>, T, bool\)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](DefaultUnDo/CollectionUnDo_T_/index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\. |
| [CollectionUnDo\(ICollection&lt;T&gt;, T, bool\)](CollectionUnDo_T_.md#DefaultUnDo.CollectionUnDo_T_.CollectionUnDo(System.Collections.Generic.ICollection_T_,T,bool) 'DefaultUnDo\.CollectionUnDo\<T\>\.CollectionUnDo\(System\.Collections\.Generic\.ICollection\<T\>, T, bool\)') | Initialise an instance of [CollectionUnDo&lt;T&gt;](DefaultUnDo/CollectionUnDo_T_/index.md 'DefaultUnDo\.CollectionUnDo\<T\>')\. |

| Explicit Interface Implementations | |
| :--- | :--- |
| [DefaultUnDo\.IUnDo\.Description](DefaultUnDo.IUnDo.Description.md 'DefaultUnDo\.CollectionUnDo\<T\>\.DefaultUnDo\.IUnDo\.Description') | Gets a description of what this [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') perform\. |
| [DefaultUnDo\.IUnDo\.Do\(\)](DefaultUnDo.IUnDo.Do().md 'DefaultUnDo\.CollectionUnDo\<T\>\.DefaultUnDo\.IUnDo\.Do\(\)') | Does an action\. |
| [DefaultUnDo\.IUnDo\.Undo\(\)](DefaultUnDo.IUnDo.Undo().md 'DefaultUnDo\.CollectionUnDo\<T\>\.DefaultUnDo\.IUnDo\.Undo\(\)') | Does the opposite of the [Do\(\)](../IUnDo/Do().md 'DefaultUnDo\.IUnDo\.Do\(\)') action\. |
