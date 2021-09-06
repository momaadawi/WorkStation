# Multi-leader replication
A natural extension of the leader-based replication model is to allow more than one
node to accept writes. Replication still happens in the same way: each node that pro‐
cesses  a  write  must  forward  that  data  change  to  all  the  other  nodes.  We  call  this  a
multi-leader configuration (also known as master-master replication or active/active).
In this setup, each leader simultaneously acts as a follower to the other leaders

## Use cases for multi-leader replication
It  rarely  makes  sense  to  use  a  multi-leader  setup  within  a  single  datacenter,  because
the  benefits  rarely  outweigh  the  added  complexity.  However,  there  are  some  situa‐
tions in which this is a reasonable configuration.

### Multi-datacenter operation
In a multi-leader configuration, you can have a leader in each datacenter
![](./media/datacenter_leaders.png)