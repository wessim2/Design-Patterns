
namespace Creational.Singleton
{
    // <summary>
    // this is a thread safe implementation of the singleton pattern
    // </summary>
    sealed class Singleton
    {
        private static Singleton _instance = default!;
        public static object _lock = new();
        public static Singleton Instance
        {
            // Double check locking
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        Console.Write("Locking");

                        if (_instance is null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
        private Singleton()
        {
            Console.WriteLine("Instantiating singleton");
        }
    }
}
