#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## UnDoFieldChange\<T\> Struct

Describes a value change operation done on a [UnDoField&lt;T&gt;](../UnDoField_T_/index.md 'DefaultUnDo\.UnDoField\<T\>')\.

```csharp
public readonly record struct UnDoFieldChange<T> : System.IEquatable<DefaultUnDo.UnDoFieldChange<T>>
```
#### Type parameters

<a name='DefaultUnDo.UnDoFieldChange_T_.T'></a>

`T`

The type of the field\.

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[DefaultUnDo\.UnDoFieldChange&lt;](DefaultUnDo/UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[T](DefaultUnDo/UnDoFieldChange_T_/index.md#DefaultUnDo.UnDoFieldChange_T_.T 'DefaultUnDo\.UnDoFieldChange\<T\>\.T')[&gt;](DefaultUnDo/UnDoFieldChange_T_/index.md 'DefaultUnDo\.UnDoFieldChange\<T\>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [UnDoFieldChange\(T, T\)](UnDoFieldChange(T,T).md 'DefaultUnDo\.UnDoFieldChange\<T\>\.UnDoFieldChange\(T, T\)') | Describes a value change operation done on a [UnDoField&lt;T&gt;](../UnDoField_T_/index.md 'DefaultUnDo\.UnDoField\<T\>')\. |

| Properties | |
| :--- | :--- |
| [NewValue](NewValue.md 'DefaultUnDo\.UnDoFieldChange\<T\>\.NewValue') | The field new value\. |
| [OldValue](OldValue.md 'DefaultUnDo\.UnDoFieldChange\<T\>\.OldValue') | The field old value\. |
