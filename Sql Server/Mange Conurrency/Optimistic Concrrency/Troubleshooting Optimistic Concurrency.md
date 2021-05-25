## Overview of Row Versioning
### How Row Versioning Works
    When we update a row in a table or index, the new row is marked with a value called the transaction sequence number (XSN) of the transaction that is doing the update. The XSN is a monotonically increasing number, which is unique within each SQL Server database. When updating a row, the previous version of the row is stored in the version store, and the new version of the row contains a pointer to the old version of the row in the version store. The new row also stores the XSN value, reflecting the time the row was modified.
    Each old version of a row in the version store might, in turn, contain a pointer to an even older version of the same row. All the old versions of a particular row are chained together in a linked list, and SQL Server might need to follow several pointers in a list to reach the right version. The version store must retain versioned rows for as long as there are operations that might require them. As long as a transaction is open, all versions of rows that have been modified by that transaction must be kept in the version store, and version of rows read by a statement (RCSI) or transaction (SI) must be kept in the version store as long as that statement or transaction is open. In addition, the version store must also retain versions of rows modified by now-completed transactions if there are any older versions of the same rows.

#### Hint
>
Before switching to a row-versioning-based isolation level, for reduced blocking and improved concurrency, we must carefully consider the tradeoffs. In addition to requiring extra management to monitor the increased use of tempdb for the version store, versioning slows the performance of UPDATE operations, due to the extra work involved in maintaining old versions. The same applies, to a much lesser extent, for DELETEoperations, since the version store must maintain at most one older version of the deleted row
>

### Types Of SanpShot-based Isolation
* read committed snapshot isolation (RCSI) – queries return committed data as of the beginning of the  current statemen
* snapshot isolation (SI) – queries return committed data as of the beginning of the current transaction.

### Enabling SI
``` sql
ALTER DATABASE <Database Name>
SET ALLOW_SNAPSHOT_ISOLATIO NON;
```

### Working with RCSI
RCSI is a statement-level snapshot isolation, which means any queries will see the most recent committed values as of the beginning of the statement (as opposed to the beginning of the transaction). Remember that RCSI is just a non-locking variation of READCOMMITTED isolation, so there is no guarantee that read operations are repeatable

### Working with SI
SI offers a transactionally consistent view of the data. Any data read will be the most recent committed version, as of the beginning of the transaction, rather than the statement. This prevents, not only dirty reads, but also non-repeatable reads and phantom reads. A key point to keep in mind is that the transaction does not start at the BEGINTRAN statement; for the purposes of SI, a transaction starts the first time the transaction accesses any data in the database

#### hint
SI >> is Transaction Based
RCSI >> Is statement Based

### Viewing database state
select * from sys.databases

Snapshot Isolation State
 * ON
 * OFF
 * IN_TRANSITION_TO_ON
 * IN_TRANSITION_TO_OFF

 READ_COMMITTED_SNAPSHOT 
  * 0
  * 1

  #### Hint
  * Conflicts are possible only with SI (and not with RCSI) because SI is transaction based, not statement based
  * Using UPDLOCK to prevent update conflicts in SI
  * The UPDLOCK hint will force SQL Server to acquire UPDATE locks for Transaction , on the selected row

  ### Hint 
  SQL Server performs the regular cleanup function as a background process, which runs every minute and reclaims all reusable space from the version store. If tempdbactually runs out of free space, SQL Server calls the cleanup function and will increase the size of the files, assuming we configured the files for auto-grow. If the disk gets so full that the files cannot grow, SQL Server will stop generating versions. If that happens, any snapshot query that needs to read a version that was not generated due to space constraints will fail.
