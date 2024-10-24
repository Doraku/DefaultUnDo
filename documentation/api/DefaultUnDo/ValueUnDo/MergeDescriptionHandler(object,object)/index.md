#### [DefaultUnDo](../../../index.md 'index')
### [DefaultUnDo](../../../index.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo](../index.md 'DefaultUnDo\.ValueUnDo')

## ValueUnDo\.MergeDescriptionHandler\(object, object\) Delegate

Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](../../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') instances to get the resulting description\.

```csharp
public delegate object? ValueUnDo.MergeDescriptionHandler(object? oldDescription, object? newDescription);
```
#### Parameters

<a name='DefaultUnDo.ValueUnDo.MergeDescriptionHandler(object,object).oldDescription'></a>

`oldDescription` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the previous [ValueUnDo&lt;T&gt;](../../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') merged\.

<a name='DefaultUnDo.ValueUnDo.MergeDescriptionHandler(object,object).newDescription'></a>

`newDescription` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The description of the new [ValueUnDo&lt;T&gt;](../../ValueUnDo_T_/index.md 'DefaultUnDo\.ValueUnDo\<T\>') merged\.

#### Returns
[System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')