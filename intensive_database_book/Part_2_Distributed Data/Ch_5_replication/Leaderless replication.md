# Leaderless replication
It once again became a fashionable  architecture  for  databases  after  Amazon  used  it  for  their  in-house  Dynamo
system .vi Riak, Cassandra and Voldemort are open source datastores with leaderless replication models inspired by Dynamo, so this kind of database is also known as Dynamo-style

In some leaderless implementations, the client directly sends its writes to several rep‐
licas,  while  in  others,  a  coordinator  node  does  this  on  behalf  of  the  client.  However,
unlike  a  leader  database,  that  coordinator  does  not  enforce  a  particular  ordering  of
writes. 

## Writing to the database when a node is down
Imagine you have a database with three replicas, and one of the replicas is currently
unavailable — perhaps  it  is  being  rebooted  to  install  a  system  update.  In  a  leader-
based configuration, if you want to continue processing writes, you may need to per‐
form a failover
**In a leaderless configuration, failover does not exist**
![](./media/leaderless_rep.png

### Read repair and anti-entropy)