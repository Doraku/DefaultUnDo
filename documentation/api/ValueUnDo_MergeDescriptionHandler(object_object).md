#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo](ValueUnDo.md 'DefaultUnDo.ValueUnDo')
## ValueUnDo.MergeDescriptionHandler(object, object) Delegate
Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances to get the resulting description.  
```csharp
public delegate object ValueUnDo.MergeDescriptionHandler(object oldDescription, object newDescription);
```
#### Parameters
<a name='DefaultUnDo_ValueUnDo_MergeDescriptionHandler(object_object)_oldDescription'></a>
`oldDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the previous [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') merged.
  
<a name='DefaultUnDo_ValueUnDo_MergeDescriptionHandler(object_object)_newDescription'></a>
`newDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the new [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') merged.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
