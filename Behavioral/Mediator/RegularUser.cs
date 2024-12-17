namespace Behavioral.Mediator
{
    public class RegularUser(string name) : User(name)
    {
        public override void Recieve(string message, string senderName)
        {
            Console.WriteLine($"{Name} recieves : {message} / from {senderName}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends : {message}");
            _mediator.Notify(this, message);
        }
    }
}
