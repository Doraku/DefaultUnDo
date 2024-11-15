#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## UnDoField\<T\> Class

Provides a simple wrapper for a field to automatically generate [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operations\.

```csharp
public class UnDoField<T>
```
#### Type parameters

<a name='DefaultUnDo.UnDoField_T_.T'></a>

`T`

The type of the filed\.

Inheritance [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object') &#129106; UnDoField<T>

| Constructors | |
| :--- | :--- |
| [UnDoField\(IUnDoManager, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;\)](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_) 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)') | Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\. |
| [UnDoField\(IUnDoManager, T, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;\)](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.UnDoField(DefaultUnDo.IUnDoManager,T,System.Func_DefaultUnDo.UnDoFieldChange_T_,object_) 'DefaultUnDo\.UnDoField\<T\>\.UnDoField\(DefaultUnDo\.IUnDoManager, T, System\.Func\<DefaultUnDo\.UnDoFieldChange\<T\>,object\>\)') | Creates a new instance of [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>')\. |

| Properties | |
| :--- | :--- |
| [Value](Value.md 'DefaultUnDo\.UnDoField\<T\>\.Value') | Gets or sets the value of the field, generating a [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation on set\. |

| Methods | |
| :--- | :--- |
| [PostSet\(T\)](PostSet(T).md 'DefaultUnDo\.UnDoField\<T\>\.PostSet\(T\)') | performs a post set treatment, included in the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |
| [PreSet\(T\)](PreSet(T).md 'DefaultUnDo\.UnDoField\<T\>\.PreSet\(T\)') | Performs a pre set treatment, included in the [IUnDo](../IUnDo/index.md 'DefaultUnDo\.IUnDo') operation\. |

| Operators | |
| :--- | :--- |
| [implicit operator T\(UnDoField&lt;T&gt;\)](implicitoperatorT(UnDoField_T_).md 'DefaultUnDo\.UnDoField\<T\>\.op\_Implicit T\(DefaultUnDo\.UnDoField\<T\>\)') | Defines an implicit conversion of a [UnDoField&lt;T&gt;](index.md 'DefaultUnDo\.UnDoField\<T\>') to a [T](index.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo\.UnDoField\<T\>\.T')\. |
