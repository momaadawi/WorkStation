phantom :
where a write in one transaction changes the result of a search query in
another transaction
Snapshot isolation avoids phantoms in
read-only queries, but in read-write transactions like the examples we discussed,
phantoms can lead to particularly tricky cases of write skew