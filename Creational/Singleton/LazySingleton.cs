
// <summary>
// same as the thread safe singleton implementation
// but using built in dotnet Base class library
// </summary>
sealed class LazySingleton
{
    private static Lazy<LazySingleton> _lazyInstance = new(() => new LazySingleton()) ;
    
    public static LazySingleton Instance => _lazyInstance.Value ;

    private LazySingleton() 
    {
        Console.WriteLine("Instatiating Singleton");
    }
    
}

