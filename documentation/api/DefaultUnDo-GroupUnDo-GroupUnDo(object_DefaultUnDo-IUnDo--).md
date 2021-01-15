### [DefaultUnDo](./DefaultUnDo.md 'DefaultUnDo').[GroupUnDo](./DefaultUnDo-GroupUnDo.md 'DefaultUnDo.GroupUnDo')
## GroupUnDo(object, DefaultUnDo.IUnDo[]) Constructor
Initialise an instance of [GroupUnDo](./DefaultUnDo-GroupUnDo.md 'DefaultUnDo.GroupUnDo').  
```csharp
public GroupUnDo(object description, params DefaultUnDo.IUnDo[] commands);
```
#### Parameters
<a name='DefaultUnDo-GroupUnDo-GroupUnDo(object_DefaultUnDo-IUnDo--)-description'></a>
`description` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')  
The description of this [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')  
  
<a name='DefaultUnDo-GroupUnDo-GroupUnDo(object_DefaultUnDo-IUnDo--)-commands'></a>
`commands` [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The sequence of [IUnDo](./DefaultUnDo-IUnDo.md 'DefaultUnDo.IUnDo') contained by the instance.  
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[commands](#DefaultUnDo-GroupUnDo-GroupUnDo(object_DefaultUnDo-IUnDo--)-commands 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[]).commands') is null.  
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
[commands](#DefaultUnDo-GroupUnDo-GroupUnDo(object_DefaultUnDo-IUnDo--)-commands 'DefaultUnDo.GroupUnDo.GroupUnDo(object, DefaultUnDo.IUnDo[]).commands') contains null elements.  
