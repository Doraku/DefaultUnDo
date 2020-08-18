### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo')
## ValueUnDo&lt;T&gt; Class
Provides an implementation of the [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') interface for setting value.  
```csharp
public sealed class ValueUnDo<T> :
IMergeableUnDo,
IUnDo
```
Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueUnDo&lt;T&gt;  

Implements [IMergeableUnDo](./DefaultUnDo-IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo'), [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
#### Type parameters
<a name='DefaultUnDo-ValueUnDo-T--T'></a>
`T`  
The type of value.  
  
### Constructors
- [ValueUnDo(System.Action&lt;T&gt;, T, T)](./DefaultUnDo-ValueUnDo-T--ValueUnDo(System-Action-T-_T_T).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(System.Action&lt;T&gt;, T, T)')
- [ValueUnDo(string, System.Action&lt;T&gt;, T, T)](./DefaultUnDo-ValueUnDo-T--ValueUnDo(string_System-Action-T-_T_T).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(string, System.Action&lt;T&gt;, T, T)')
### Fields
- [MergeInterval](./DefaultUnDo-ValueUnDo-T--MergeInterval.md 'DefaultUnDo.ValueUnDo&lt;T&gt;.MergeInterval')
