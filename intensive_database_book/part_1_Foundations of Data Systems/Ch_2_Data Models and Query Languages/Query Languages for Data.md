## Query Languages for Data
*   SQL  is  a  declarative  query  language
*    IMS  and  CODASYL  queried  the  database using imperative code

##### Remember
>
declarative  languages  often  lend  themselves  to  parallel  execution.  Today,CPUs are getting faster by adding more cores, not by running at significantly higher
clock speeds than before. Imperative code is very hard to parallelize across multiple cores and multiple machines, because it specifies instructions that must be per‐
formed  in  a  particular  order.  Declarative  languages  have  a  better  chance  of  getting faster  in  parallel  execution,  because  they  specify  only  the  pattern  of  the  results,  but not  the  algorithm  
>

### MapReduce querying
* MapReduce  is  a  programming  model  for  processing  large  amounts  of  data  in  bulk
across many machine
* A limited form of MapReduce is
supported  by  some  NoSQL  data  stores,  including  MongoDB  and  CouchDB,  as  a
mechanism for performing read-only queries across many documents

### Graph-like Data Models
* A graph consists of two kinds of object
    * vertices (also known as nodes or entities)
    * edges  (also  known  as  relationships  or  arcs)

*   kinds  of  data  can  be  modeled  as  a graph
    *   Social graphs
        -   Vertices are people, edges indicate which people know each other.
    *   The web graph
        -   Vertices are web pages, edges indicate HTML links to other pages
    *   Road or rail networks
        -   Vertices  are  junctions,  and  edges  represent  the  roads  or  railway  lines  between them.

*   Well-known  algorithms  can  operate  on  these  graphs:
    *   the  shortest  path in a road network is useful for routing
    *   ageRank on the web graph can be used to determine the popularity of a web page

*   databases graph model examples in the book
    *   property  graph  model
        -   implemented  byNeo4j,  Titan,  InfiniteGraph
    *   the triple-store  model
        -   implemented  by  Datomic, AllegroGraph  and  others

#### query languages  used in graph model
*   three  declarative  query  languages  for graphs
    -   Cypher, SPARQL, and Datalog.
*   there are also imperative graph query  languages  such  as  **Gremlin**
####  graph  processing  frameworks 
    *   Pregel

#### graph exmaple:
[Example of graph-structured data](./graph_example.png)

### Property Graph
##### In the property graph model, each vertex consists of:
*   a unique identifier
*   a set of outgoing edges
*   a set of incoming edges
*   a collection of properties (key-value pairs)

##### Each edge consists of:
*   a unique identifier
*   the vertex at which the edge starts (the tail vertex)
*   the vertex at which the edge ends (the head vertex)
*   a label to describe the kind of relationship between the two vertices
*   a collection of properties (key-value pairs)


#### The Cypher query language
Cypher  is  a  declarative  query  language  for  property  graphs,  created  for  the  Neo4j graph  database 

**Example. A subset of the data, represented as a Cypher query.**
``` Cypher  
CREATE
  (NAmerica:Location {name:'North America', type:'continent'}),
  (USA:Location      {name:'United States', type:'country'  }),
  (Idaho:Location    {name:'Idaho',         type:'state'    }),
  (Lucy:Person       {name:'Lucy' }),
  (Idaho) -[:WITHIN]->  (USA)  -[:WITHIN]-> (NAmerica),
  (Lucy)  -[:BORN_IN]-> (Idaho)
```

**Example. Cypher query to find people who emigrated from the US to Europe.**
``` Cypher
MATCH
  (person) -[:BORN_IN]->  () -[:WITHIN*0..]-> (us:Location {name:'United States'}),
  (person) -[:LIVES_IN]-> () -[:WITHIN*0..]-> (eu:Location {name:'Europe'})
RETURN person.name
```
### Triple-stores Model and SPARQL
in a triple-store, all information is stored in the form of very simple three-part state‐
ments: (subject, predicate, object)
**example**: in the triple (Jim, likes, bananas), Jim is the subject, likes is the predicate (verb), and bananas is the object.

#### HINT
>
The main difference between graph databases and triple stores is how they model the graph
>

