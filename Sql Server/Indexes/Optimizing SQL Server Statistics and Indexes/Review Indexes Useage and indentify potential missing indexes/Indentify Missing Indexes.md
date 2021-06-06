### Identifying Missing Indexes
*   Dynamic Management Views (DMVs)   
*   Database Tuning Advisor

#### Missing indexes in DMV's
*   Automatically tracked
*   Generated by the Query Optimiser
*   Limited in what is considered

##### Querying the Missing Index DMVs
``` Sql
SELECT DB_NAME(mid.database_id) AS DatabaseName,
       OBJECT_SCHEMA_NAME(mid.object_id, mid.database_id) AS SchemaName,
       OBJECT_NAME(mid.object_id, mid.database_id) AS ObjectName,
       migs.avg_user_impact,
       mid.equality_columns,
       mid.inequality_columns,
       mid.included_columns
FROM sys.dm_db_missing_index_groups mig
    INNER JOIN sys.dm_db_missing_index_group_stats migs
        ON migs.group_handle = mig.index_group_handle
    INNER JOIN sys.dm_db_missing_index_details mid
        ON mig.index_handle = mid.index_handle;
```
##### Hint
>
    Look at query plan you will find details to determine missing indexes
>
#### Database Tuning Advisor
*   Tunes a query or a workload
*   Tests out recommendations on target database
*   Tends to over-recommend

#### DTA’s workflow consists of three steps that can be done on separate instances
*   Generate a Workload
*   Analyse Database
*   Implement Recommendations 

###### Usage Hint
>
*   dont use DTA in production server it's add overhead,
*   whenever you can use DTA use it, its better for determine indexes on workload but unlike DMV's better for single query
>

### Usage:
* create Profiler tracker for period of time
* import trace file in DTA and save recommedation
* import the recommedation the apply it watch performance(Set statistics io on to read how much pages has  been read) before and after 

