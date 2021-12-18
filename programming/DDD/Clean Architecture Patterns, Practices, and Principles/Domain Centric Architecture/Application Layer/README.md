# Application Layer
### What are Layers?

### Classic Three-layer Architecture
![](./media/three_layer.png)

This work fine for CRUD operations

### Modern four-layerd Architecture(Domain-cerntric architecture)
![](./media/four_layer.png)

### Application Layer Responsiplity
* Implements use cases 
* High level applicaiton logic
* knows about the domain layer
* No Knowledge of other layers
* contain interfaces

- Dependency Inversion :
It states That Abstraction should not depend on details, rather details should depend on abstraction
- Inversion Of Control:
Our dependecies oppose the flow of control in application, this provide several benefits such as providing independent deployability
- Independent Deployability:
we can replace implementaion in production withoud affecting the abstraction that is dependes upon
- Flexiable and maintainable


### Layer Dependencies
![](./media/arc_vision.png)

### Applicaiton Layer
Pros: 
* Focus on domain
* Easy to understand
* Follow DIP

Cons: 
* Additional layer cost (in creating and maintaining application layer )
* Require extra thought (about what belongs to the application layer versus what belongs to Domain Layer )

### info
- every folder in the applicaiton layer represted as key which is the aggregate root in DDD meaning
Ex: Customers, Employee
- Search for command object pattern, command object handler pattern

### graph the dependecies
![](./media/application_graph.png)

