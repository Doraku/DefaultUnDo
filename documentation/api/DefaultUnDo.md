#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
This is the full API documentation of DefaultUnDo.  
### Namespaces
<a name='DefaultUnDo'></a>
## DefaultUnDo Namespace

| Classes | |
| :--- | :--- |
| [CollectionUnDo&lt;T&gt;](CollectionUnDo_T_.md 'DefaultUnDo.CollectionUnDo&lt;T&gt;') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') operation.<br/> |
| [DictionaryUnDo&lt;TKey,TValue&gt;](DictionaryUnDo_TKey_TValue_.md 'DefaultUnDo.DictionaryUnDo&lt;TKey,TValue&gt;') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') operation.<br/> |
| [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for a group of operations.<br/> |
| [ICollectionExtension](ICollectionExtension.md 'DefaultUnDo.ICollectionExtension') | Provides a method to wrap an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') to an UnDo collection linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.<br/> |
| [IDictionaryExtension](IDictionaryExtension.md 'DefaultUnDo.IDictionaryExtension') | Provides a method to wrap an [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') to an UnDo dictionary linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.<br/> |
| [IListExtension](IListExtension.md 'DefaultUnDo.IListExtension') | Provides a method to wrap an [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') to an UnDo list linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.<br/> |
| [ISetExtension](ISetExtension.md 'DefaultUnDo.ISetExtension') | Provides a method to wrap an [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') to an UnDo set linked to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.<br/> |
| [IUnDoManagerExtension](IUnDoManagerExtension.md 'DefaultUnDo.IUnDoManagerExtension') | Provides methods to create [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and add them to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').<br/> |
| [ListUnDo&lt;T&gt;](ListUnDo_T_.md 'DefaultUnDo.ListUnDo&lt;T&gt;') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') operation.<br/> |
| [UnDo](UnDo.md 'DefaultUnDo.UnDo') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for custom do and undo action.<br/> |
| [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;') | Provides a simple wrapper for a field to automatically generate [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operations.<br/> |
| [UnDoManager](UnDoManager.md 'DefaultUnDo.UnDoManager') | Provides an implementation of the command pattern to execute operations and return to a previous state by undoing them.<br/> |
| [ValueUnDo](ValueUnDo.md 'DefaultUnDo.ValueUnDo') | Provides a global [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan') to use as default merge interval for all [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;').<br/> |
| [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') | Provides an implementation of the [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') interface for setting value.<br/> |

| Structs | |
| :--- | :--- |
| [UnDoCollectionOperation](UnDoCollectionOperation.md 'DefaultUnDo.UnDoCollectionOperation') | Provides data for the operation about to be performed on an undo collection.<br/> |
| [UnDoFieldChange&lt;T&gt;](UnDoFieldChange_T_.md 'DefaultUnDo.UnDoFieldChange&lt;T&gt;') | Describes a value change operation done on a [UnDoField&lt;T&gt;](UnDoField_T_.md 'DefaultUnDo.UnDoField&lt;T&gt;').<br/> |

| Interfaces | |
| :--- | :--- |
| [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo') | Provides a method to try to merge two [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') instances into a single one.<br/> |
| [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') | Provides methods to execute an action and remove its effect.<br/> |
| [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager') | Provides properties and methods of the command pattern to execute operations and return to a previous state by undoing them.<br/> |
| [IUnDoTransaction](IUnDoTransaction.md 'DefaultUnDo.IUnDoTransaction') | Represents a transaction to record multiple undo operations as a single operation in the history of a [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').<br/> |

| Enums | |
| :--- | :--- |
| [UnDoCollectionAction](UnDoCollectionAction.md 'DefaultUnDo.UnDoCollectionAction') | Describes the action that will be performed on an [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') and recorded by an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').<br/> |

| Delegates | |
| :--- | :--- |
| [GroupUnDo.MergeDescriptionHandler(object, object, object)](GroupUnDo_MergeDescriptionHandler(object_object_object).md 'DefaultUnDo.GroupUnDo.MergeDescriptionHandler(object, object, object)') | Represents a method that will be called when merging a [GroupUnDo](GroupUnDo.md 'DefaultUnDo.GroupUnDo') and a [IMergeableUnDo](IMergeableUnDo.md 'DefaultUnDo.IMergeableUnDo') instances to get the resulting description.<br/> |
| [ValueUnDo&lt;T&gt;.MergeDescriptionHandler(object, T, object, T)](ValueUnDo_T__MergeDescriptionHandler(object_T_object_T).md 'DefaultUnDo.ValueUnDo&lt;T&gt;.MergeDescriptionHandler(object, T, object, T)') | Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances to get the resulting description.<br/> |
| [ValueUnDo.MergeDescriptionHandler(object, object)](ValueUnDo_MergeDescriptionHandler(object_object).md 'DefaultUnDo.ValueUnDo.MergeDescriptionHandler(object, object)') | Represents a method that will be called when merging two [ValueUnDo&lt;T&gt;](ValueUnDo_T_.md 'DefaultUnDo.ValueUnDo&lt;T&gt;') instances to get the resulting description.<br/> |
  
