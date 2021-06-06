### Effects of Rebuild Column Store indexes
-   completely recreate the index
-   All resulting row groups will be compressed
-   All delted rows will be removed
*   hint: rebuild is intensive work, it takes alot of time and has memory pressure effect

### Effects of Reorgnize Column Store indexes
-   reorgnize is probaply what you are going to be doing most of the time
-   it compresses all **COLSED** rowgroups
-   remove deleted rows if > 10% rows in rowgroup deleted (added in sql server 2016) in earlier verions reorgnize dosent effect deleted rows at all
-   combine compressed rowGroups up to row maxaimum(to one) (added in sql server 2016)


