## DefaultUnDo 0.2.0
breaking changes:  
changed description from string to object  
changed AsUnDo extension methods description factory to take an UnDoCollectionOperation  
changed IUnDoManager.BeginGroup to IUnDoManager.BeginTransaction and require a call to IUnDoTransaction.Commit to validate opeartions  

added UnDoField  
changed to not historize IUnDo command generated when already executing an IUnDo command  

[nuget package](https://www.nuget.org/packages/DefaultUnDo/0.2.0)

## DefaultUnDo 0.1.0
added Description property on IUnDo  
added maxCapacity on UnDoManager constructor  
added IMergeableUnDo interface for mergeable operation  

[nuget package](https://www.nuget.org/packages/DefaultUnDo/0.1.0)

## DefaultUnDo 0.0.1
first release  

[nuget package](https://www.nuget.org/packages/DefaultUnDo/0.0.1)