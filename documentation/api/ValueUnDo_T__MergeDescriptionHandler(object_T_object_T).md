#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')
## ValueUnDo&lt;T&gt;.MergeDescriptionHandler(object, T, object, T) Delegate
Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances to get the resulting description.  
```csharp
public delegate object ValueUnDo<T>.MergeDescriptionHandler(object oldDescription, T oldValue, object newDescription, T newValue);
```
#### Type parameters
<a name='DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_T'></a>
`T`  
  
#### Parameters
<a name='DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_oldDescription'></a>
`oldDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the previous [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') merged.
  
<a name='DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_oldValue'></a>
`oldValue` [T](ValueUnDo_T__MergeDescriptionHandler(object_T_object_T).md#DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_T 'DefaultUnDo.ValueUnDo&lt;T&gt;.MergeDescriptionHandler(object, T, object, T).T')  
The old value used when undoing the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').
  
<a name='DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_newDescription'></a>
`newDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the new [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') merged.
  
<a name='DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_newValue'></a>
`newValue` [T](ValueUnDo_T__MergeDescriptionHandler(object_T_object_T).md#DefaultUnDo_ValueUnDo_T__MergeDescriptionHandler(object_T_object_T)_T 'DefaultUnDo.ValueUnDo&lt;T&gt;.MergeDescriptionHandler(object, T, object, T).T')  
The new value used when redoing the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The new description that will be using for the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').
