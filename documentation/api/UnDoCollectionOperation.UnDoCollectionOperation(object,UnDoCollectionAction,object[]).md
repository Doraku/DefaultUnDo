#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')

## UnDoCollectionOperation(object, UnDoCollectionAction, object[]) Constructor

Initializes a new instance of the [UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation') struct.

```csharp
public UnDoCollectionOperation(object collection, DefaultUnDo.UnDoCollectionAction action, params object?[] parameters);
```
#### Parameters

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).collection'></a>

`collection` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The collection on which the action is performed.

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).action'></a>

`action` [UnDoCollectionAction](UnDoCollectionAction.md 'DefaultUnDo.UnDoCollectionAction')

The action performed.

<a name='DefaultUnDo.UnDoCollectionOperation.UnDoCollectionOperation(object,DefaultUnDo.UnDoCollectionAction,object[]).parameters'></a>

`parameters` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The parameters of the action performed.