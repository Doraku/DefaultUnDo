#### [DefaultUnDo](DefaultUnDo.md 'DefaultUnDo')
### [DefaultUnDo](DefaultUnDo.md#DefaultUnDo 'DefaultUnDo')
## IUnDoManagerExtension Class
Provides methods to create [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') command and add them to an [IUnDoManager](IUnDoManager.md 'DefaultUnDo.IUnDoManager').  
```csharp
public static class IUnDoManagerExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IUnDoManagerExtension  
### Methods

***
[Do&lt;T&gt;(IUnDoManager, Action&lt;T&gt;, T, T, object)](IUnDoManagerExtension_Do_T_(IUnDoManager_Action_T__T_T_object).md 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Action&lt;T&gt;, T, T, object)')

Sets a value as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[Do&lt;T&gt;(IUnDoManager, IList&lt;T&gt;, int, T, object)](IUnDoManagerExtension_Do_T_(IUnDoManager_IList_T__int_T_object).md 'DefaultUnDo.IUnDoManagerExtension.Do&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object)')

Sets the element at the specified index on a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[Do&lt;TKey,TValue&gt;(IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object)](IUnDoManagerExtension_Do_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md 'DefaultUnDo.IUnDoManagerExtension.Do&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object)')

Sets the element with the specified key on a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[Do(IUnDoManager, Action, Action, object)](IUnDoManagerExtension_Do(IUnDoManager_Action_Action_object).md 'DefaultUnDo.IUnDoManagerExtension.Do(DefaultUnDo.IUnDoManager, System.Action, System.Action, object)')

Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified doAction and undoAction.  

***
[DoAdd&lt;T&gt;(IUnDoManager, ICollection&lt;T&gt;, T, object)](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ICollection_T__T_object).md 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object)')

Adds a value to a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoAdd&lt;T&gt;(IUnDoManager, ISet&lt;T&gt;, T, object)](IUnDoManagerExtension_DoAdd_T_(IUnDoManager_ISet_T__T_object).md 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ISet&lt;T&gt;, T, object)')

Adds an item from a [System.Collections.Generic.ISet&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ISet-1 'System.Collections.Generic.ISet`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoAdd&lt;TKey,TValue&gt;(IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object)](IUnDoManagerExtension_DoAdd_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_TValue_object).md 'DefaultUnDo.IUnDoManagerExtension.DoAdd&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, TValue, object)')

Adds a value to a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoClear&lt;T&gt;(IUnDoManager, ICollection&lt;T&gt;, object)](IUnDoManagerExtension_DoClear_T_(IUnDoManager_ICollection_T__object).md 'DefaultUnDo.IUnDoManagerExtension.DoClear&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, object)')

Clears a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoInsert&lt;T&gt;(IUnDoManager, IList&lt;T&gt;, int, T, object)](IUnDoManagerExtension_DoInsert_T_(IUnDoManager_IList_T__int_T_object).md 'DefaultUnDo.IUnDoManagerExtension.DoInsert&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, T, object)')

Inserts an item to a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') at the specified index as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoOnDo(IUnDoManager, Action, object)](IUnDoManagerExtension_DoOnDo(IUnDoManager_Action_object).md 'DefaultUnDo.IUnDoManagerExtension.DoOnDo(DefaultUnDo.IUnDoManager, System.Action, object)')

Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no undo.  

***
[DoOnUndo(IUnDoManager, Action, object)](IUnDoManagerExtension_DoOnUndo(IUnDoManager_Action_object).md 'DefaultUnDo.IUnDoManagerExtension.DoOnUndo(DefaultUnDo.IUnDoManager, System.Action, object)')

Does a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation on the manager with the specified action with no do.  

***
[DoRemove&lt;T&gt;(IUnDoManager, ICollection&lt;T&gt;, T, object)](IUnDoManagerExtension_DoRemove_T_(IUnDoManager_ICollection_T__T_object).md 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.ICollection&lt;T&gt;, T, object)')

Removes an item from a [System.Collections.Generic.ICollection&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1 'System.Collections.Generic.ICollection`1') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoRemove&lt;TKey,TValue&gt;(IUnDoManager, IDictionary&lt;TKey,TValue&gt;, TKey, object)](IUnDoManagerExtension_DoRemove_TKey_TValue_(IUnDoManager_IDictionary_TKey_TValue__TKey_object).md 'DefaultUnDo.IUnDoManagerExtension.DoRemove&lt;TKey,TValue&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IDictionary&lt;TKey,TValue&gt;, TKey, object)')

Removes the item with the specified key from a [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  

***
[DoRemoveAt&lt;T&gt;(IUnDoManager, IList&lt;T&gt;, int, object)](IUnDoManagerExtension_DoRemoveAt_T_(IUnDoManager_IList_T__int_object).md 'DefaultUnDo.IUnDoManagerExtension.DoRemoveAt&lt;T&gt;(DefaultUnDo.IUnDoManager, System.Collections.Generic.IList&lt;T&gt;, int, object)')

Removes an item from a [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') at the specified index as a [IUnDo](IUnDo.md 'DefaultUnDo.IUnDo') operation.  