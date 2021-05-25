### detect Escalation
    If a whole table is locked, rather than just individual rows,
    then this may cause blocking and reduce concurrency, so we need a way to detect it when it occurs, and take remedial action.
    There are a couple of ways to detect lock escalation. The easiest way is to use the Lock:Escalation event class in SQL Trace/Profiler.
#### Resolving lock escalation
  If escalation has actually caused blocking problems, the best solution is usually to try to tune queries, ensuring that appropriate indexes are used and as few pages as possible need to be accessed, and as few locks as possible need to be acquired. In addition, a best practice is always to keep transactions as short as possible, so that SQL Server doesn't acquire and hold any non-essential locks.
### Controlling escalation
  There are occasions where we may wish to prevent escalation altogether, for a certain table. If the table must be available at all times by as many sessions as possible, because of key lookup data it contains, it can impact an entire application if one session is able to lock the entire table.
###### Hint 1
 >
  Locks never escalate from row to page, but they can escalate from row to table or from page to table. 
 >
###### Hint 2
>
 Be careful when disabling escalation for a huge table,
  as this would mean SQL Server is forced to keep potentially tens of thousands (or more!) page locks,
   which will require a substantial amount of memory.
>

### SQL Server provides two trace flags that can control lock escalation for an entire SQL Server instance.
  * Trace flag **1224**: disables escalation due to exceeding the upper limit on the number of locks acquired for a statement,
      but escalation can still occur if the amount of memory used for locks exceeds the threshold.
  
  * Trace flag **1211**:  disables escalation in all cases. Be very careful if considering turning this trace flag on,
      as SQL Server could end up acquiring an enormous number of locks.
### use the sys.dm_tran_locks view to detect table locks
``` SQL
  SELECT 
    tl.resource_type,
    tl.request_mode,
    tl.request_status,
    CASE tl.resource_type
        WHEN 'OBJECT' THEN OBJECT_NAME(tl.resource_associated_entity_id)
        WHEN 'KEY' THEN (
            SELECT OBJECT_NAME(p.object_id) 
            FROM sys.partitions p
            WHERE p.hobt_id = tl.resource_associated_entity_id
            )
    END AS ObjectName

    FROM sys.dm_tran_locks tl
    JOIN sys.dm_exec_sessions es
    ON tl.request_session_id = es.session_id
    WHERE tl.resource_database_id = DB_ID()
```