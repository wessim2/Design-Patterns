namespace Behavioral.Mediator
{
    public class ChatRoom : IChatMediator
    {
        private readonly List<User> _users = [];
        public void AddUser(User user)
        {
            _users.Add(user);
            user.SetMediator(this);
        }

        public void Notify(User sender, string message)
        {
            foreach (var user in _users)
            {
                if (sender != user)
                {
                    user.Recieve(message, sender.Name);
                }
            }
        }
    }
}
