namespace Behavioral.Mediator
{
    public class AdminUser(string name) : User(name)
    {
        public override void Recieve(string message, string senderName)
        {
            Console.WriteLine($"Admin {Name} recieves from {senderName}: {message}");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"Admin {Name} annouces : {message}");
            _mediator.Notify(this, $"Admin message : {message}");
        }

        public void BroadCastMessage(string alert)
        {
            Console.WriteLine($"{Name} broadcast alert : {alert}");
            _mediator.Notify(this, $"Admin Alert : {alert}");

        }
    }
}
