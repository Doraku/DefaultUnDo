#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')
## GroupUnDo.MergeDescriptionHandler(object, object, object) Delegate
Represents a method that will be called when merging a [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo') and a [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo') instances to get the resulting description.  
```csharp
public delegate object GroupUnDo.MergeDescriptionHandler(object oldDescription, object newDescription, object mergedDescription);
```
#### Parameters
<a name='DefaultUnDo_GroupUnDo_MergeDescriptionHandler(object_object_object)_oldDescription'></a>
`oldDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the previous [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo') merged.
  
<a name='DefaultUnDo_GroupUnDo_MergeDescriptionHandler(object_object_object)_newDescription'></a>
`newDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the new [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo') merged.
  
<a name='DefaultUnDo_GroupUnDo_MergeDescriptionHandler(object_object_object)_mergedDescription'></a>
`mergedDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of the new resulting [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo') merged.
  
#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
