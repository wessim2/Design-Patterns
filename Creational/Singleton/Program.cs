using Creational.Singleton;

// <instruction>
// uncomment the step you want to try
// </instruction>

// 1 Multi Threads

/*ParallelEnumerable.Range(0, 1000)
    .ForAll(_ =>
    {
        Singleton singleton = Singleton.Instance;
    });*/


// 2 Multi Threads using BCL (Base Class Library)

/*ParallelEnumerable.Range(0, 1000)
    .ForAll(_ =>
    {
        Console.WriteLine("Thread");
        LazySingleton singleton = LazySingleton.Instance;
    });*/


// 3 Nested imp

/*ParallelEnumerable.Range(0, 1000)
    .ForAll(_ =>
    {
        // string className = NestedSingleton.ClassName;
        
        // if we access to the className field we won't inititate an Instance 
        
        NestedSingleton singleton = NestedSingleton.Instance;
    });*/
