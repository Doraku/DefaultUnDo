#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo').[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>')

## ValueUnDo<T>.MergeDescriptionHandler(object, T, object, T) Delegate

Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') instances to get the resulting description.

```csharp
public delegate object ValueUnDo<T>.MergeDescriptionHandler(object? oldDescription, T oldValue, object? newDescription, T newValue);
```
#### Type parameters

<a name='DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).T'></a>

`T`
#### Parameters

<a name='DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).oldDescription'></a>

`oldDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the previous [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') merged.

<a name='DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).oldValue'></a>

`oldValue` [T](ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).md#DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).T 'DefaultUnDo.ValueUnDo<T>.MergeDescriptionHandler(object, T, object, T).T')

The old value used when undoing the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>').

<a name='DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).newDescription'></a>

`newDescription` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The description of the new [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>') merged.

<a name='DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).newValue'></a>

`newValue` [T](ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).md#DefaultUnDo.ValueUnDo_T_.MergeDescriptionHandler(object,T,object,T).T 'DefaultUnDo.ValueUnDo<T>.MergeDescriptionHandler(object, T, object, T).T')

The new value used when redoing the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>').

#### Returns
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The new description that will be using for the resulting merged [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo<T>').