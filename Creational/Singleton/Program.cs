using Creational.Factory.Example;
using Creational.Factory.Example.Levels;
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


// <section>
// This section is dedicated for the factory 

// simple 
/*Level level1 = new CaveLevel();
IEnemy enemy1 = level1.CreateEnemy();
enemy1.Attack();
enemy1.Scream();

Level level2 = new CaveHouseLevel();
IEnemy enemy2 = level2.CreateEnemy();
enemy2.Attack();
enemy2.Scream();*/

Level level1 = new CaveLevel();
level1.EnemyReact();

Level level2 = new CaveHouseLevel();
level2.EnemyReact();