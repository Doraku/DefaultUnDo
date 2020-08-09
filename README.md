# DefaultUnDo
DefaultUnDo is a simple [Command pattern](https://en.wikipedia.org/wiki/Command_pattern) implementation to ease the addition of an undo/redo feature.

[![NuGet](https://buildstats.info/nuget/DefaultUnDo)](https://www.nuget.org/packages/DefaultUnDo)
[![Coverage Status](https://coveralls.io/repos/github/Doraku/DefaultUnDo/badge.svg?branch=master)](https://coveralls.io/github/Doraku/DefaultUnDo?branch=master)
![continuous integration status](https://github.com/doraku/defaultundo/workflows/continuous%20integration/badge.svg)
[![preview package](https://img.shields.io/badge/preview-package-blue?style=flat&logo=github)](https://github.com/Doraku/DefaultUnDo/packages/26448)

- [Release note](./documentation/RELEASENOTE.md 'Release note')
- [Api documentation](./documentation/api/DefaultUnDo.md 'Api documentation')
<a/>

- [Requirement](#Requirement)
- [Overview](#Overview)

<a name='Requirement'></a>
# Requirement
Compatible from .NETStandard 1.0.  
For development, a C#8.0 compatible environment, net framework 4.8, net core 1.0 and netcore 3.0 are required to build and run all tests (it is possible to disable some target in the test project if needed).

<a name='Overview'></a>
# Overview
Easy to use, just instanciate a `UnDoManager` and get going. Numerous extension methods are available to ease the integration.
```csharp
IUnDoManager manager = new UnDoManager();

// do an action and record it in the manager, undoAction being the undo equivalent of the action
manager.Do(doAction, undoAction);

if (manager.CanUndo)
{
    manager.Undo();
}

if (Manager.CanRedo)
{
    manager.Redo();
}

// clean any recorded action
manager.Clear();
```

`ICollection<T>`, `IList<T>`, `IDictionary<TKey, TValue>` and `ISet<T>` can be coverterted to an undo instance so that any action performed on them will generate a `IUnDo` action on the manager.
```csharp
IUnDoManager manager = new UnDoManager();

// use myList as you would use your list normaly
IList<int> myList = new List<int>().AsUnDo(manager);

// use myCollection as you would use your collection normaly
// note than the returned collection also implement INotifyCollectionChanged
ICollection<int> myCollection = new ObservableCollection<int>().AsUnDo(manager);

// use myDictionary as you would use your dictionary normaly
Dictionary<int, string> myDictionary = new Dictionary<int, string>().AsUnDo(manager);

// use mySet as you would use your set normaly
ISet<int> mySet = new HashSet<int>().AsUnDo(manager);
```

It is possible to declare a group scope for you operations so a single undo/redo will execute all the contained operations.
```csharp
IUnDoManager manager = new UnDoManager();

using (manager.BeginGroup())
{
    manager.Do(action1, undo1);
    manager.Do(action2, undo2);
}

// both undo2 and undo1 will be called in this order
manager.Undo();

// both action1 and action2 will be called in this order
manager.Redo();
```

If a group scope is declared inside an other group scope, all operations will be grouped in the same undo/redo operation.
```csharp
IUnDoManager manager = new UnDoManager();

using (manager.BeginGroup())
{
    manager.Do(action1, undo1);

    using (manager.BeginGroup())
    {
        manager.Do(action2, undo2);
    }
}

// both undo2 and undo1 will be called in this order
manager.Undo();

// both action1 and action2 will be called in this order
manager.Redo();
```

`IUnDoManager.Undo` and `IUnDoManager.Redo` calls are not supported when inside a group operation. Also the actions recorded by the manager should not generate more operations themselves.

To keep track of the modification, a `Version` property is available on the manager.

Missing something? you can easily extend what you need by creating your own implementations of the `IUnDo` interface and extension methods to ease the usage. Feel free to open an issue or send a pull request.