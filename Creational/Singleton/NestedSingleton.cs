namespace Creational.Singleton
{
    // <summary>
    // In this Singleton example we have two static fields 
    // without the Nested implementation , if we access the ClassName property 
    // we initiate all the other props 
    // with the nested implementation , we initiate an Instance only if we access this field
    // </summary>
    sealed class NestedSingleton
    {
        public static string ClassName => "Singleton";
        public static NestedSingleton Instance => Nested.Instance;
        
        private class Nested
        {
            internal static NestedSingleton Instance { get; } = new();

            static Nested()
            {
                Console.WriteLine("Nested static");
            }
        }
        // delays the initialisation of all static fiields until it's first used
        static NestedSingleton() 
        {
            Console.WriteLine("static constructor call");         
        }
        private NestedSingleton() 
        {
            Console.WriteLine("Instatiating");
        }
    }
}
