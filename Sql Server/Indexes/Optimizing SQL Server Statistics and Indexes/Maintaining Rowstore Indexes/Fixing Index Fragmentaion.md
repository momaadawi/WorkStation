### Fixing Index Fragmentaion
##### There are two option sql server has fixing index fragmentaion
*   the index rebuild (**recreates indexe**) - take longer time on large table
*   the index reorgnazie (**shuffles the index back into order**) swap out pages order to get it back to orderd sequence

###### Syntex for index rebuild
``` sql
    Alter Index [All | <Index name>]
    on [<Table Name>]
    Rebuild
    with
    PAD_INDEX = {ON | OFF}
    FILLFACTOR = <fillfactor precentage>
    SORT_IN_TEMP = {ON | OFF}
    ONLINE = { ON | OFF | [(<low_pioriry_lock_wait>)]}
    RESUMABLE = { ON | OFF}
    MAX_DURATION = <time> [minites] -- is how long duration the rebuilt allowed to run before it automaticly paused
    MAXDOP = max_degree_of_parallelism
```
###### Syntex for index rebuild
``` sql
    ALter Index [ALL | <index name>]
    ON TableName
    REORGANIZE
    WITH
    LOB_COMPACTION = { ON | OFF}
```

#### Considiration
*   The Commanly Accepted industry standard answer is to **reorgnize** indexes with fragmentation between 10 and 30%,
*  **rebuild** any with fragmentation over 30%
*  ignore any index with under 1000 pages in them
*   downtime: how much maintenance downtime do you have ?, if system is 24/7 with no downtime allowed you are probably not rebuilding ever because with online opotion locks are taken plus
*   Workload: OLTP, OLAP, Hyprid
    -   OLTP : may not suffer from fragmentation 
    - OLAP: Suffer 
    - hyprid : some times based on type of queries
*   log Impact: how much space usage in the transaction log is acceptable

##### Hint
>
the old index is dropped at the end of rebuilt process not the beginning
>

#### Fixing Fragmentaion using Wizard 
[Fixing Indexes using Wizad]: https://www.mssqltips.com/sqlservertip/6019/sql-server-maintenance-plan-index-rebuild-and-reorganize-tasks/

#### other way to fix indexes fragmentaion (the favourit one)
>
dont reinevent the wheel use precreated scripts 
* https://ola.hallengren.com/
>




