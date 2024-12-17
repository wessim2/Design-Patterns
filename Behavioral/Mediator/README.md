## Mediator

### Overview
This implementation demonstrates the Mediator Design Pattern where a Chatroom acts as the central mediator for communication between Users. The pattern promotes loose coupling by ensuring that objects (Users) do not communicate directly but through a mediator (IChatMediator).

### Benefits
1. Loose coupling.
1. Encapsulating the core logic of communication inside one object.
1. More maintainable and scalable.

### Drawbacks
1. the mediator becomes the core object that encapsulates all the logic. And that makes it complex.