# Microservices

## Components
![](./media/components.png)

Components are how would typiclly subdivide the layers architecture once it has grown beyond a manageable size we typiclly implement components as seperate witin our overall solution then when we build these projects we create output files like DLL in c#, assemblies in .NET,  Jar in java and Gem in ruby
this allow us to work on the compnents individually intergrate them as necessery, and deply them independently.
all of the data for each component stack are typiclly stored in a single database


![](./media/single_domain.png)

![](./media/overlapping_domain.png)

![](./media/bounded_context.png)

## Microservices
![](./media/microservies.png)

- microservices divide a single large application into smaller sybsystem
- these microservices commincate together using clearly defined interfaces typically over lightweight web protocols for example: JSON over HTTP via APIs
- microservices divide large teams into smaller development teams that is one team for each microservice or set of microservices these services are also very independent of one another each one can have it's own persestince, programming language, architecture and operating system
- in addation you can independentely deply each micorservice and independentely scale them as needed

## Why Microservices?
Pros:
- Flatter cost curve -> the cost of the microservices grow slowly as the system get bigger 
- Cohesion / Coupling
- independence ->  you what ever tech you want for each microservice

Cons: 
- Highr
