#
## Introduction to the liskov subititution priciple
The Liskov substitution principle (LSP) is a collection of guidelines for creating inheritance hierarchies in which a client can reliably use any class or subclass without compromising the expected behavior

It extends the Open/Closed principle and enables you to replace objects of a parent class with objects of a subclass without breaking the application

If S is a subtype of T, then objects of type T may be replaced with objects of type S,
without breaking the program .

There are three code ingredients relating to the LSP:
* Base Type
* Sub Type
* Context

### LSP rules
* Contract rules
* Variance rules

## Contracts
pass

## Covariance and Contravariance
covariance is how variables related to one object 
**Covariance Example**:
``` c# 
    public class Entity
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        }
    // . . .
    public class User : Entity
    {
        public string EmailAddress { get; private set; }
        public DateTime DateOfBirth { get; private set; }
    }

    public Interface IEntityRepository<T> Where T : Entity
    {
        T GetById(int id);
    }

    public class UserRepository : IEntityRepository<User>
    {
        public User GetById(int id)
        {
            return new User();
        }
    }
```

**Contravariance** : 
Contravariance is a similar concept to covariance. Whereas covariance relates to the treatment of
types that are used as return values, contravariance relates to the treatment of types that are used
as method parameters.