#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo').[UnDoCollectionOperation](index.md 'DefaultUnDo\.UnDoCollectionOperation')

## UnDoCollectionOperation\(object, UnDoCollectionAction, object\[\]\) Constructor

Provides data for the operation about to be performed on an undo collection\.

```csharp
public UnDoCollectionOperation(object Collection, DefaultUnDo.UnDoCollectionAction Action, params object?[] Parameters);
```
#### Parameters

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).Collection'></a>

`Collection` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')

The collection on which the action is performed\.

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).Action'></a>

`Action` [UnDoCollectionAction](../UnDoCollectionAction/index.md 'DefaultUnDo\.UnDoCollectionAction')

The action performed\.

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).Parameters'></a>

`Parameters` [System\.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System\.Object')[\[\]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System\.Array')

The parameters of the action performed\.