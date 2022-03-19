#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')

## UnDoField<T> Class

Provides a simple wrapper for a field to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.

```csharp
public class UnDoField<T>
    where T : notnull
```
#### Type parameters

<a name='DefaultUnDo.UnDoField_T_.T'></a>

`T`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDoField<T>

| Constructors | |
| :--- | :--- |
| [UnDoField(IUnDoManager, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;)](UnDoField_T_.UnDoField(IUnDoManager,Func_UnDoFieldChange_T_,object_).md 'DefaultUnDo.UnDoField<T>.UnDoField(DefaultUnDo.IUnDoManager, System.Func<DefaultUnDo.UnDoFieldChange<T>,object>)') | Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>'). |
| [UnDoField(IUnDoManager, T, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;)](UnDoField_T_.UnDoField(IUnDoManager,T,Func_UnDoFieldChange_T_,object_).md 'DefaultUnDo.UnDoField<T>.UnDoField(DefaultUnDo.IUnDoManager, T, System.Func<DefaultUnDo.UnDoFieldChange<T>,object>)') | Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>'). |

| Properties | |
| :--- | :--- |
| [Value](UnDoField_T_.Value.md 'DefaultUnDo.UnDoField<T>.Value') | Gets or sets the value of the field, generating a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on set. |

| Methods | |
| :--- | :--- |
| [PostSet(T)](UnDoField_T_.PostSet(T).md 'DefaultUnDo.UnDoField<T>.PostSet(T)') | performs a post set treatment, included in the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation. |
| [PreSet(T)](UnDoField_T_.PreSet(T).md 'DefaultUnDo.UnDoField<T>.PreSet(T)') | Performs a pre set treatment, included in the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation. |
| [ToT()](UnDoField_T_.ToT().md 'DefaultUnDo.UnDoField<T>.ToT()') | Returns the underlying [T](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo.UnDoField<T>.T'). |

| Operators | |
| :--- | :--- |
| [implicit operator T(UnDoField&lt;T&gt;)](UnDoField_T_.implicitoperatorT(UnDoField_T_).md 'DefaultUnDo.UnDoField<T>.op_Implicit T(DefaultUnDo.UnDoField<T>)') | Defines an implicit conversion of a [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField<T>') to a [T](UnDoField_T_.md#DefaultUnDo.UnDoField_T_.T 'DefaultUnDo.UnDoField<T>.T'). |
