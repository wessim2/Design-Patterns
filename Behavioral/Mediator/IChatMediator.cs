namespace Behavioral.Mediator
{
    public interface IChatMediator
    {
        public void Notify(User user, string message);
        public void AddUser(User user);
    }
}
