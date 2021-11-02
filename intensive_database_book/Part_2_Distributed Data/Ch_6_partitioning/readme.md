## Terminological confusion
What  we  call  a  partition  here  is  called  a  shard  in  MongoDB,  Elasticsearch  and  SolrCloud,  a  region  in  HBase,  a tablet  in  BigTable,  a vnode  in  Cassandra  and  Riak,  and  a  vBucket  in  Couchbase.  However,  partitioning  is  the most  established  term,  so  we’ll  stick  with that.

The  main  reason  for  wanting  to  partition  data  is  scalability.  Different  partitions  can
be  placed  on  different  nodes  in  a  shared-nothing  cluster,  a  large  dataset  can  be  distributed
across many disks, and the query load can be distributed across many processors.

The  main  reason  for  wanting  to  partition  data  is  scalability

In this chapter we will first look at different approaches for partitioning a large data‐
sets, and observe how the indexing of data interacts with partitioning. We’ll then talk
about  rebalancing,  which  is  necessary  if  you  want  to  add  or  remove  nodes  in  your
cluster. Finally, we’ll get an overview of how databases route requests to the right par‐
tition and execute queries.