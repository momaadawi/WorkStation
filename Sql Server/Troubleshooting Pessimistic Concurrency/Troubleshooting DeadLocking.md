# Troubleshooting Deadlocking
    A *deadlock* occurs when two sessions are each waiting for a resource that the other session has locked, and neither one can continue because the other is preventing it from gaining access to the required resource.
### Types of deadlock
   #####   In SQL Server, two main types of deadlock can occur    
     * cycle deadlock 
     * conversion deadlock

   ###### cycle deadlock: 
>
     Each transaction holds a resource needed by the other process. Neither can proceed and, without intervention, both would be stuck in deadlock forever
>
 ###### conversion deadlock: 
>
    Process A and Process B both hold a shared lock on the same page. Each process wants to convert its shared lock to an exclusive lock but cannot do so because of the other process's lock. Again, intervention is required.
>

### Automatic deadlock detection
    Automatic deadlock detectionSQL Server automatically detects deadlocks and intervenes through the lock manager, which provides deadlock detection for locks. A separate thread, called LOCK_MONITORchecks the system for deadlocks every 5 seconds.

###### how sql server choose victim process?
>
*   the process that would be least expensive to roll back( considiring the amount of work the process  already done)
*   That process is killed and is sent error message 1205
*    Using the SETDEADLOCK_PRIORITY statement : 
    >
        There are 21 different priority levels, from –10 to 10. The value LOW is equivalent to –5, NORMAL is 0, and HIGH is 5
    >
>

### Finding the cause of deadlocks
    To determine the cause of a deadlock, we need to know the resources involved and the types of locks acquired and requested. For this kind of information, SQL Server provides Trace Flag 1222 (this flag supersedes 1204, which was frequently used in earlier versions of SQL Server.

