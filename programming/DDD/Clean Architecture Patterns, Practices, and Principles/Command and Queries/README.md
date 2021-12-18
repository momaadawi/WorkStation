# Command And Queries Seperation

Command:
* does something
* shoud modify state
* should not return value

Qurey:
* Answer Question
* should not modify state
* should return value

## CQRS Architecture
CQRS is domain centric architecture in smart way it's know when to talk to the domain via commands, and when to talk directly to the database via queries

## There are three types of CQRS Architecture
* Single Database CQRS
    - single database
    - commands use domain (via ORM )
    - queries use database (Via ORM using LINQ, StoredProcedure)

![](./media/single_cqrs.png)

* Two database CQRS
    - use two database
    - commands use write db
    - quries use read DB (such as denormlized datastore)
    - the modification to write db pushed into the read db using evetual consistency pattern

![](./media/twodb_cqrs.png)

* Event Sourcing CQRS
    -
