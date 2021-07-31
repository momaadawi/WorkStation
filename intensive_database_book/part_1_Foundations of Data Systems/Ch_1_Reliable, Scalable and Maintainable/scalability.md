#### Scalability  
>
is  the  term  we  use  to  describe  a  system’s  ability  to  cope  with  increased
load
>
#### Describing load 
read about Fan out write and fan out read
###### Example:
>
 If you tweet then that is a write and twitter delivers that to all the subscribers feeds as soon as it is written, fan out write. The work is all done at the time of write to figure out who will get this tweet.

Facebook does not immediately deliver a written post. It waits until users are actually consuming their feed. Facebook at this time looks for posts that have been written that this user is eligible to read; fan out read. The processing of whether a user has permission to read a particular post is done at read time.
>
#### Describing performance
pass
#### Batch Processing 
google it
#### read about!!
* Service level Objectives(SLO)
* Service level Agreements(SLA)
* Head-of-line blocking (HOL blocking)
    -   occurs if there is a single queue of data packets waiting to be transmitted, and the packet at the head of the queue (line) cannot move forward due to congestion 
#### Percentiles in Practice
High percentiles become especially important in backend services that are called mul‐
tiple times as part of serving a single end-user request. Even if you make the calls in
parallel, the end-user request still needs to wait for the slowest of the parallel calls to
complete.
#### **solution**
there are  algorithms  which  can  calculate  a  good  approximation  of  percentiles  at  minimal
CPU  and  memory  cost,  such  as  **forward  decay**,  **t-digest** or  **HdrHistogram**. Beware that averaging percentile

#### Scaling_Up and Scaling_out
*   **Scaling_up:** vertical  scaling,  moving to a more powerful machine
*   **Scaling_out:** horizontal  scaling,  distributing  the  load across multiple smaller machines is also known as a shared nothing architecture.

#### when to start scaling u