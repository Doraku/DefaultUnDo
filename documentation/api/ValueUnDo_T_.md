#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## ValueUnDo&lt;T&gt; Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for setting value.  
```csharp
public sealed class ValueUnDo<T> :
DefaultUnDo.IMergeableUnDo,
DefaultUnDo.IUnDo
```
#### Type parameters
<a name='DefaultUnDo_ValueUnDo_T__T'></a>
`T`  
The type of value.
  

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ValueUnDo&lt;T&gt;  

Implements [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo'), [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
### Constructors

***
[ValueUnDo(object, Action&lt;T&gt;, T, T)](ValueUnDo_T__ValueUnDo(object_Action_T__T_T).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(object, System.Action&lt;T&gt;, T, T)')

Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').  

***
[ValueUnDo(Action&lt;T&gt;, T, T)](ValueUnDo_T__ValueUnDo(Action_T__T_T).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.ValueUnDo(System.Action&lt;T&gt;, T, T)')

Initialises an instance of [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').  
### Fields

***
[MergeInterval](ValueUnDo_T__MergeInterval.md 'DefaultUnDo.ValueUnDo&lt;T&gt;.MergeInterval')

The [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') interval equivalent [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances should respect to be mergeable.  
Default value is 500ms.  
### Explicit Interface Implementations

***
[DefaultUnDo.IMergeableUnDo.TryMerge(IUnDo, IUnDo)](ValueUnDo_T__DefaultUnDo_IMergeableUnDo_TryMerge(IUnDo_IUnDo).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.DefaultUnDo.IMergeableUnDo.TryMerge(DefaultUnDo.IUnDo, DefaultUnDo.IUnDo)')

Merges the current instance with the specified [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo').  

***
[DefaultUnDo.IUnDo.Description](ValueUnDo_T__DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.ValueUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Description')

Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.  

***
[DefaultUnDo.IUnDo.Do()](ValueUnDo_T__DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.ValueUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Do()')

Does an action.  

***
[DefaultUnDo.IUnDo.Undo()](ValueUnDo_T__DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.ValueUnDo&lt;T&gt;.DefaultUnDo.IUnDo.Undo()')

Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.  
