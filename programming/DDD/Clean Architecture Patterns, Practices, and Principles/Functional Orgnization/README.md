# Funcitonl Orgnization
* Screaming Architecture
* Functional vs. Categorical

## Screaming Architecture
The architecture should scream the intent of the system.
![](./media/scream.png)

Use cases: are the representaion of the user's interaction with the system 

### MVC (categorical cohesion) vs. Functional Orgnization (High level use-cases) (functional cohesion)
![](./media/mvc_func.png)

in functional orginzation it's much easier to determine the intent of the software

### Why use functional orginization?
pros:
- Spatial locality (Items that are used together live together)
- Easy Navigation
- Avoid vendor lock-in (avoid framework lock-in becuase we are not forced into the folder structure that the vendor insist to use their framework)

Cons:
- Lose framework conventions
- Lose automatic scaffolding 
