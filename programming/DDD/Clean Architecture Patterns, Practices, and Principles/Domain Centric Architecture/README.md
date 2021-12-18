# Domain Centric Architecture

## Database Centric vs Domain Centric Architecture
![](./media/database_vs_domain.png)

in Domain Centric Architecture:
- The database is just implentaion detail outside the architecture, the domain is essential and the database is just a detail
- Domain is essential
- use cases are essential
- Presentation is a detail 
- presistence is just a detail 


### Types of Domain Centric Architecture
All of this architecture, they all put the domain in the center wrap it in Application Layer which embds the use cases
* Haxagonal Architecture
* Onion Architeture
* The Clean Architecture

## Why use Domain Centric Architecture?
Pros:
* Focus on domain
* Less coupling between the domain logic and the implementaion details ex: Presistence, Database and Operating System
* Allows For DDD

Cons: 
* Change is defficult
* Requires more thought
* Initial Higher Cost
