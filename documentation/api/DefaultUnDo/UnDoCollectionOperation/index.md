#### [DefaultUnDo](../../index.md 'index')
### [DefaultUnDo](../../index.md#DefaultUnDo 'DefaultUnDo')

## UnDoCollectionOperation Struct

Provides data for the operation about to be performed on an undo collection\.

```csharp
public readonly record struct UnDoCollectionOperation : System.IEquatable<DefaultUnDo.UnDoCollectionOperation>
```

Implements [System\.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')[UnDoCollectionOperation](index.md 'DefaultUnDo\.UnDoCollectionOperation')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System\.IEquatable\`1')

| Constructors | |
| :--- | :--- |
| [UnDoCollectionOperation\(object, UnDoCollectionAction, object\[\]\)](UnDoCollectionOperation(object,UnDoCollectionAction,object[]).md 'DefaultUnDo\.UnDoCollectionOperation\.UnDoCollectionOperation\(object, DefaultUnDo\.UnDoCollectionAction, object\[\]\)') | Provides data for the operation about to be performed on an undo collection\. |

| Properties | |
| :--- | :--- |
| [Action](Action.md 'DefaultUnDo\.UnDoCollectionOperation\.Action') | The action performed\. |
| [Collection](Collection.md 'DefaultUnDo\.UnDoCollectionOperation\.Collection') | The collection on which the action is performed\. |
| [Parameters](Parameters.md 'DefaultUnDo\.UnDoCollectionOperation\.Parameters') | The parameters of the action performed\. |
