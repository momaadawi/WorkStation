# Replication
Replication  means  keeping  a  copy  of  the  same  data  on  multiple  machines  that  are
connected via a network
###  why you might want to replicate data ? 
* To keep data geographically close to your users (and thus reduce latency).
* To  allow  the  system  to  continue  working  even  if  some  parts  of  the  system  have failed (and thus increase availability).
* To  scale  out  the  number  of  machines  that  can  serve  read  queries  (and  thus increase read throughput).

If the data that you’re replicating does not change over time, then replication is easy:
you  just  need  to  copy  the  data  to  every  node  once,  and  you’re  done.  All  of  the  diffi‐
culty  in  replication  lies  in  handling  changes  to  replicated  data

###  three  popular  algorithms  for  replicating  changes between  nodes
*   single-leader replication
*   multi-leade replication
*   leaderless replication

## Leaders and Followers
It works as follows:
*   One  of  the  replicas  is  designated  the  leader  (also  known  as  master  or  primary).
When  clients  want  to  write  to  the  database,  they  must  send  their  request  to  the
leader, which first writes the new data to its local storage
*   The other replicas are known as followers (read replicas, slaves, or hot standbysi).
Whenever  the  leader  writes  new  data  to  its  local  storage,  it  also  sends  the  data
change  to  all  of  its  followers  as  part  of  a  replication  log  or  change  stream.  Each
follower  takes  the  log  from  the  leader  and  updates  its  local  copy  of  the  database
*   When a client wants to read from the database, it can query either the leader or
any of the followers. However, writes are only accepted on the leader (the follow‐
ers are read-only from the client’s point of view).