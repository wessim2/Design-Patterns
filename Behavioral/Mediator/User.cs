namespace Behavioral.Mediator
{
    public abstract class User(string name)
    {
        public string Name { get; protected set; } = name;
        protected IChatMediator _mediator = null!;

        public void SetMediator(IChatMediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Send(string message);
        public abstract void Recieve(string message, string senderName);
    }
}
