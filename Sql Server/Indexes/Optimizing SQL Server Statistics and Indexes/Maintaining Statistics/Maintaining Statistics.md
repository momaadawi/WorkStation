### What are Statistics?
*   Aggregated data about data in table
*   Measure of uniqueness of the left-based subset of  column
every object has it's stats
*   Distribution of data within columns (this is stored in histogram with max of 250 steps)
*   Not kept in sync with the table

### Why Statistics are important?
*   Statistics are used by the query optimizer in the generation of execution plan to:
    -   Estimate rows affected and data sizes
    -   Choose appropriate operators for the number of rows
    -   Calculate memory needed to run query

### Effects of Wrong statistics
*   slow queries
*   High CPU usage
*   Excessive IO's
*   Splills to TempDB
-------------------------------------------------------------------------------------
### Reaing Statistics
``` sql
DBCC SHOW_STATISTICS(Transactions, 'idx_Transactions_TransactionDate')
-- results: 
-- First table: for the columns that statistics built from
-- secound : list the densities off the left based subsets of the columns
-- thired : is the histogram 
```
### use it to test statiscs performance and see how it choose query plan  
``` sql
Alter database [<Database Name>] set AUTO_STATISTICS_UPDATE {ON | OFF}
```

### Automatic stats updates
*   Triggered after a certain number of changes to the underlying table
*   Update occurs the next time the stats are needed
*   Sampled update on larger tables

### Options for keeping stats up to date
*   Auto updates( probaply most used)
*   Index Maintenance (rebuild not orgnize)
*   Manual updates

### manual statistics update
index rebuild update statistics but if you are not going to maintain index there has to be another way to managae statistics
##### Syntax for Statistics Updates
    ``` sql 
    UPDATE STATISTICS TableName [ALL | <index name>]
    WITH
    FULLSCAN | SAMPLE |RESAMPLE
    [NORECOMPUTE]
    INCREMENTAL = {ON|OFF}
    ```

### Guidline for stats maintain
DO SOME:
*   Auto update statistics is effective in small tables but it offen dosen't on larger tables or more frequently modified tables
*   if you have time update statistics with fullscan every night 
    - remember : the main side effect of update stats is ivalidating cache execution plans but it's offen a good thing it means that the new plan will based on up to date data
* be careful of doing sampled updates after index maintenace it's worth than a waste of time 
*   last thing : dont re invent the wheel use maintanence scripts as [ola hallengren](https://ola.hallengren.com/)
