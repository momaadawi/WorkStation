### IntroDuction and why column store need maintainence
Column store dose not have key then there is no logical order for the index pages instead rows forms in rows group of up to millions rows with no tree structres,
When **Delta Store** reaches a million rows it's not compressed immedtiatly
*   **Tuple mover**: is background proccess Which takes row Groups and compressed them
 ##### Why do ColumnStore Indexes need Maintenance?
-   **UnCompressed RowGroups** : uncompressed row groups are b-tree structures and are slower than compressed groups
-   **Deleted Rows** : delted in cloumn store are logical, rows are falgged as deleted
-   **Undersized RowGroups** : the ideal number of rows in rowGroup is one million(dont't understadnd it ) 

##### Column Store index with open RowGroups
``` Sql
SELECT OBJECT_SCHEMA_NAME(rg.object_id) AS SchemaName,
       OBJECT_NAME(rg.object_id) AS TableName,
       i.name AS IndexName,
       i.type_desc AS IndexType,
       rg.partition_number,
       rg.row_group_id,
       rg.total_rows,
       rg.size_in_bytes,
       rg.deleted_rows,
       rg.[state],
       rg.state_description
FROM sys.column_store_row_groups AS rg
    INNER JOIN sys.indexes AS i ON i.object_id = rg.object_id AND i.index_id = rg.index_id
WHERE state_description != 'TOMBSTONE'
ORDER BY TableName,
         IndexName,
         rg.partition_number,
         rg.row_group_id;
```
##### Column Store indexs with deleted rows
``` Sql
SELECT OBJECT_SCHEMA_NAME(rg.object_id) AS SchemaName,
       OBJECT_NAME(rg.object_id) AS TableName,
       i.name AS IndexName,
       i.type_desc AS IndexType,
       rg.partition_number,
       rg.state_description,
       COUNT(*) AS NumberOfRowgroups,
       SUM(rg.total_rows) AS TotalRows,
       SUM(rg.size_in_bytes) AS TotalSizeInBytes,
       SUM(rg.deleted_rows) AS TotalDeletedRows
FROM sys.column_store_row_groups AS rg INNER JOIN sys.indexes AS i ON i.object_id = rg.object_id AND i.index_id = rg.index_id
GROUP BY rg.object_id,
         i.name,
         i.type_desc,
         rg.partition_number,
         rg.state_description
ORDER BY TableName,
         IndexName,
         rg.partition_number;
```
