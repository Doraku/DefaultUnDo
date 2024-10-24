#### [DefaultUnDo](../../../index.md 'index')
### [DefaultUnDo](../../../index.md#DefaultUnDo 'DefaultUnDo').[GroupUnDo](../index.md 'DefaultUnDo\.GroupUnDo')

## GroupUnDo\.MergeDescriptionHandler\(object, object, object\) Delegate

Represents a method that will be called when merging a [GroupUnDo](../index.md 'DefaultUnDo\.GroupUnDo') and a [IMergeableUnDo](../../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo') instances to get the resulting description\.

```csharp
public delegate object GroupUnDo.MergeDescriptionHandler(object? oldDescription, object? newDescription, object? mergedDescription);
```
#### Parameters

<a name='DefaultUnDo.GroupUnDo.MergeDescriptionHandler(object,object,object).oldDescription'></a>

`oldDescription` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the previous [GroupUnDo](../index.md 'DefaultUnDo\.GroupUnDo') merged\.

<a name='DefaultUnDo.GroupUnDo.MergeDescriptionHandler(object,object,object).newDescription'></a>

`newDescription` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the new [IMergeableUnDo](../../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo') merged\.

<a name='DefaultUnDo.GroupUnDo.MergeDescriptionHandler(object,object,object).mergedDescription'></a>

`mergedDescription` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the new resulting [IMergeableUnDo](../../IMergeableUnDo/index.md 'DefaultUnDo\.IMergeableUnDo') merged\.

#### Returns
[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')  
The final description to use\.