#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## UnDo Class
Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for custom do and undo action.  
```csharp
public sealed class UnDo :
DefaultUnDo.IUnDo
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; UnDo  

Implements [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')  
### Constructors

***
[UnDo(object, Action, Action)](UnDo_UnDo(object_Action_Action).md 'DefaultUnDo.UnDo.UnDo(object, System.Action, System.Action)')

Initialises an instance of [UnDo](UnDo.md 'DefaultUnDo.UnDo').  

***
[UnDo(Action, Action)](UnDo_UnDo(Action_Action).md 'DefaultUnDo.UnDo.UnDo(System.Action, System.Action)')

Initialises an instance of [UnDo](UnDo.md 'DefaultUnDo.UnDo').  
### Explicit Interface Implementations

***
[DefaultUnDo.IUnDo.Description](UnDo_DefaultUnDo_IUnDo_Description.md 'DefaultUnDo.UnDo.DefaultUnDo.IUnDo.Description')

Gets a description of what this [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') perform.  

***
[DefaultUnDo.IUnDo.Do()](UnDo_DefaultUnDo_IUnDo_Do().md 'DefaultUnDo.UnDo.DefaultUnDo.IUnDo.Do()')

Does an action.  

***
[DefaultUnDo.IUnDo.Undo()](UnDo_DefaultUnDo_IUnDo_Undo().md 'DefaultUnDo.UnDo.DefaultUnDo.IUnDo.Undo()')

Does the opposite of the [Do()](IUnDo_Do().md 'DefaultUnDo.IUnDo.Do()') action.  
