#### What is a Database Model?
A database model shows the logical structure of a database, including the relationships and constraints that determine how data can be stored and accessed.

#### Types of database models
*   Hierarchical database model
*   Relational model
*   Network model
*   Object-oriented database model
*   Entity-relationship model
*   Document model
*   Entity-attribute-value model
*   Star schema
*   The object-relational model

##### Relational Model vs. Document Model
pass

#### The object-relational mismatch
**terms**
*   polyglot persistence
*   impedance mismatch
>
The JSON representation has better locality than the multi-table schema . If you want to fetch a profile in the relational example, you need to either perform  multiple  queries  (query  each  table  by  user_id)  or  perform  a  messy  multiway join between the users table and its subordinate tables. In the JSON representation, all the relevant information is in one place, and one query is sufficient.The one-to-many relationships from the user profile to its positions, educational history and contact information imply a tree structure in the data, and the JSON representation makes this tree structure explicit.
>

#### joins in NOSQL
If the database itself does not support joins, you have to emulate a join in application
code by making multiple queries to the database.
At the time of writing, joins are supported in RethinkDB, not supported in MongoDB, and only supported in pre-declared views in CouchDB

#### The NetWork Model(CODASYL)
*   model is a generalization of the hierarchical model. In the tree structure  of  the  hierarchical  model,  every  record  has  exactly  one  parent,  in  the  network model,  a  record  can  have  multiple  parents.
*   The  links  between  records  in  the  network  model  are  not  foreign  keys
*   A  query  in  CODASYL  was  performed  by  moving  a  cursor  through  the  database  by iterating  over  lists  of  records  and  following  access  paths
*   querying and updating
the database complicated and inflexible. With both the hierarchical and the network
model, if you didn’t have a path to the data you wanted, you were in a difficult situation

#### The relational model
in a relational database, the query optimizer automatically decides which parts of the query  to  execute  in  which  order,  and  which  indexes  to  use.  Those  choices  are  effectively the “access path”

##### some diffrence among models
-   foreign key in realtional model, document refrence in document model
-   the network nad hierarchical model have access path
-   join in relational model accur in query time 
-   join in the netwrok model accur in insert time

#### Relational vs. document databases today
##### Which data model leads to simpler application code?
* If  the  data  in  your  application  has  a  document-like  structure  (i.e.  a  tree  of  one-to-
many relationships, where typically the entire tree is loaded at once), then it’s proba‐
bly  a  good  idea  to  use  a  document  model. 
* The  document  model  has  limitations — for  example,  you  cannot  refer  directly  to  a
nested item within a document, but instead you need to say something like “the sec‐
ond item in the list of positions for user 251” (much like an access path in the hierarch‐
ical  model).  
* poor  support  for  joins  in  document  databases  may  or  may  not  be  a  problem,
depending  on  the  application.




