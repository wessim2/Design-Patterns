// See https://aka.ms/new-console-template for more information
using Behavioral.Mediator;


ChatRoom chatRoom = new();

RegularUser bob = new("bob");
RegularUser alice = new("alice");
AdminUser admin = new("admin");

chatRoom.AddUser(bob);
chatRoom.AddUser(alice);
chatRoom.AddUser(admin);


bob.Send("Hello everyone");
alice.Send("Hello bob");
admin.BroadCastMessage("Stop please");



