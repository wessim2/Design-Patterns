
namespace Creational.Factory
{
    // Concrete class that creates a concrete class from a set of defined classes
    // using inheritance or interface imp
    class PasswordFactory1
    {
        public static IPassword Generate(string password)
        {
            return password.Length > 5 ? 
                new ComplexPassword() : 
                new SimplePassword(); 
        }
    }

    class ComplexPassword : IPassword; 
    class SimplePassword : IPassword; 

    interface IPassword;

    // concrete class that creates a concrete class
    class PasswordFactory
    {
        public static Password Generate(/*  */)
        {
            // complex logic
            return new Password();
        } 
    }
    // A static factory method - a static method that is defined in a concrete type that creates this type
    // this is instead of creating a whole factory class that creates 
    public class Password
    {
        /*private Password() { 
        }*/
        public static Password Generate()
        {
            return new Password();
        }
    }
}
