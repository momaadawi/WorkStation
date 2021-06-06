### Maintaining Rowstore Indexes
#### Cause of  Index Fragmantaion
SQL Server index fragmentation is a common source of database performance degradation. Fragmentation occurs when there is a lot of empty space on a data page (internal fragmentation) or when the logical order of pages in the index doesn't match the physical order of pages in the data file (external fragmentation).
#### Effects of fragmantation
*   Permormance: Decrease performance for large range scan from disk
    >
    Question: What is Read Ahead Read in SQL Server?

    Answer: The read-ahead mechanism in SQL Server’s feature which brings data pages into the buffer cache even before the data is requested by the query.
    **Happen Only when the data on disk not memory**
    >
*   Spave: **Partialy empty pages** mean indexes take up more 

#### Indentify Fragmanted Indexes
``` sql 
SELECT OBJECT_SCHEMA_NAME(i.object_id) AS SchemaName, OBJECT_NAME(i.object_id) TableName, 
	i.name,
	ips.partition_number, 
	ips.index_type_desc, 
	ips.index_level,
	ips.avg_fragmentation_in_percent,
	ips.page_count,
	ips.avg_page_space_used_in_percent
	FROM sys.indexes i 
		INNER JOIN sys.dm_db_index_physical_stats(DB_ID(), NULL, NULL, NULL, 'detailed') ips 
		-- limited mode retun only the leaf level where index level equals 0
		-- detaild mode retun all index levels from root to leaf 
		--hint : the index level is down up so leaf's index level is 0 
			ON ips.object_id = i.object_id AND ips.index_id = i.index_id
	-- WHERE i.name = '<index_Name>'
    -- WHERE ips.avg_fragmentation_in_percent > 30 and ips.page_count > 1000

	-- # Result:
	-- rebuild index: avg_fragmentation_in_percent in 10-30
	-- regornize index : avg_fragmentation_in_percent > 30
```
