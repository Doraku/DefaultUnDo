#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
This is the full API documentation of DefaultUnDo.  
### Namespaces
<a name='DefaultUnDo'></a>
## DefaultUnDo Namespace
### Classes

***
[CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') operation.  

***
[DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') operation.  

***
[GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for a group of operations.  

***
[ICollectionExtension](ICollectionExtension.md 'DefaultUnDo.ICollectionExtension')

Provides a method to wrap an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[IDictionaryExtension](IDictionaryExtension.md 'DefaultUnDo.IDictionaryExtension')

Provides a method to wrap an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[IListExtension](IListExtension.md 'DefaultUnDo.IListExtension')

Provides a method to wrap an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[ISetExtension](ISetExtension.md 'DefaultUnDo.ISetExtension')

Provides a method to wrap an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension')

Provides methods to create [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and add them to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').  

***
[ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') operation.  

***
[UnDo](UnDo.md 'DefaultUnDo.UnDo')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for custom do and undo action.  

***
[UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;')

Provides a simple wrapper for a field to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.  

***
[UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager')

Provides an implementation of the command pattern to execute operations and return to a previous state by undoing them.  

***
[ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;')

Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for setting value.  
### Structs

***
[UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation')

Provides data for the operation about to be performed on an undo collection.  

***
[UnDoFieldChange&lt;T&gt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;')

Describes a value change operation done on a [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;').  
### Interfaces

***
[IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo')

Provides a method to try to merge two [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instances into a single one.  

***
[IUnDo](IUnDo.md 'DefaultUnDo.IUnDo')

Provides methods to execute an action and remove its effect.  

***
[IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')

Provides properties and methods of the command pattern to execute operations and return to a previous state by undoing them.  

***
[IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction')

Represents a transaction to record multiple undo operations as a single operation in the history of a [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
### Enums

***
[UnDoCollectionAction](UnDoCollectionAction.md 'DefaultUnDo.UnDoCollectionAction')

Describes the action that will be performed on an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') and recorded by an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager')./>  
  
