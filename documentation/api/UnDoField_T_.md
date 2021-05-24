#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## UnDoField&lt;T&gt; Class
Provides a simple wrapper for a field to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  
```csharp
public class UnDoField<T>
```
#### Type parameters
<a name='DefaultUnDo_UnDoField_T__T'></a>
`T`  
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDoField&lt;T&gt;  

| Constructors | |
| :--- | :--- |
| [UnDoField(IUnDoManager, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;)](UnDoField_T__UnDoField(IUnDoManager_Func_UnDoFieldChange_T__object_).md 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)') | Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;').<br/> |
| [UnDoField(IUnDoManager, T, Func&lt;UnDoFieldChange&lt;T&gt;,object&gt;)](UnDoField_T__UnDoField(IUnDoManager_T_Func_UnDoFieldChange_T__object_).md 'DefaultUnDo.UnDoField&lt;T&gt;.UnDoField(DefaultUnDo.IUnDoManager, T, System.Func&lt;DefaultUnDo.UnDoFieldChange&lt;T&gt;,object&gt;)') | Creates a new instance of [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;').<br/> |

| Properties | |
| :--- | :--- |
| [Value](UnDoField_T__Value.md 'DefaultUnDo.UnDoField&lt;T&gt;.Value') | Gets or sets the value of the field, generating a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on set.<br/> |

| Methods | |
| :--- | :--- |
| [PostSet(T)](UnDoField_T__PostSet(T).md 'DefaultUnDo.UnDoField&lt;T&gt;.PostSet(T)') | performs a post set treatment, included in the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.<br/> |
| [PreSet(T)](UnDoField_T__PreSet(T).md 'DefaultUnDo.UnDoField&lt;T&gt;.PreSet(T)') | Performs a pre set treatment, included in the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.<br/> |

| Operators | |
| :--- | :--- |
| [implicit operator T(UnDoField&lt;T&gt;)](UnDoField_T__implicitoperatorT(UnDoField_T_).md 'DefaultUnDo.UnDoField&lt;T&gt;.op_Implicit T(DefaultUnDo.UnDoField&lt;T&gt;)') | Defines an implicit conversion of a [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;') to a [T](UnDoField_T_.md#DefaultUnDo_UnDoField_T__T 'DefaultUnDo.UnDoField&lt;T&gt;.T').<br/>  |
