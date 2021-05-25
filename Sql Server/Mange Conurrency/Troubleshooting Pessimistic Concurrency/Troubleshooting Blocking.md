### blocking Situations 
  * happen when tasks have conflicting requests for locks
  * also happen when there is contention on other resources such as *memory, I/O, or processor resource*

### Detecting blocking problems
    when processes are blocked for extended periods of time,
    it can appear to end-users as if queries are running much more slowly

  #### tools for detecting lock-based blocking problems
  * 
    * DMV sys.dm_os_waiting_tasks
    * Perf Mon
    * SQLDiag utility
  

## Finding Blocking 

### Query to return all locks in a WAIT state and the locks they are waiting on, including database and object names.
``` SQL
USE AdventureWorks;
GO
SELECT  L1.resource_type ,
        DB_NAME(L1.resource_database_id) AS DatabaseName ,
        CASE L1.resource_type
          WHEN 'OBJECT'
          THEN OBJECT_NAME(L1.resource_associated_entity_id,
                           L1.resource_database_id)
          WHEN 'DATABASE' THEN 'DATABASE'
          ELSE CASE WHEN L1.resource_database_id = DB_ID()
                    THEN ( SELECT   OBJECT_NAME(object_id,
                                                L1.resource_database_id)
                           FROM     sys.partitions
                           WHERE    hobt_id =
                                      L1.resource_associated_entity_id
                         )
                    ELSE NULL
               END
        END AS ObjectName ,
        L1.resource_description ,
        L1.request_session_id ,
        L1.request_mode ,
        L1.request_status
FROM    sys.dm_tran_locks AS L1
        JOIN sys.dm_tran_locks AS L2
                 ON L1.resource_associated_entity_id =
                       L2.resource_associated_entity_id
WHERE   L1.request_status <> L2.request_status
        AND ( L1.resource_description = L2.resource_description
              OR ( L1.resource_description IS NULL
                   AND L2.resource_description IS NULL
                 )
            )
ORDER BY L1.resource_database_id ,
        L1.resource_associated_entity_id ,
        L1.request_status ASC;
```

### Query to return the blocked processes and the queries they are running.
``` SQL
  SELECT  T.session_id AS waiting_session_id ,
        DB_NAME(L.resource_database_id) AS DatabaseName ,
        
        T.waiting_task_address ,
        L.request_mode ,
        ( SELECT SUBSTRING(Q.text, ( R.statement_start_offset / 2 ) + 1,
                           ( ( CASE R.statement_end_offset
                                 WHEN -1 THEN DATALENGTH(Q.text)
                                 ELSE R.statement_end_offset
                              END - R.statement_start_offset ) / 2 ) + 1)
          FROM      sys.dm_exec_requests AS R
                    CROSS APPLY sys.dm_exec_sql_text(R.sql_handle) AS Q
          WHERE     R.session_id = L.request_session_id
        ) AS waiting_query_text ,
        L.resource_type ,
        L.resource_associated_entity_id ,
        T.wait_type ,
        T.blocking_session_id ,
        T.resource_description AS blocking_resource_description ,
        CASE WHEN T.blocking_session_id > 0
             THEN ( SELECT  ST2.text
                    FROM    sys.sysprocesses AS P
                            CROSS APPLY
                            sys.dm_exec_sql_text(P.sql_handle) AS ST2
                    WHERE   P.spid = T.blocking_session_id
                  )
             ELSE NULL
        END AS blocking_query_text
FROM    sys.dm_os_waiting_tasks AS T
        JOIN sys.dm_tran_locks AS L 
                 ON T.resource_address = L.lock_owner_address

```