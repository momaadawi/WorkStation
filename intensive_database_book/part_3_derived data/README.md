## Systems of Record and Derived Data
On a high level, systems that store and process data can be grouped into two broad categories:
*   Systems of record:
    -   A system of record, also known as source of truth, holds the authoritative version
of your data. When new data comes in, e.g. as user input, it is first written here.
Each fact is represented exactly once (the representation is typically normalized).
If there is any discrepancy between another system and the system of record,
then the value in the system of record is (by definition) the correct one.

*   Derived data systems:
    -   Data in a derived system is the result of taking some existing data from another
system and transforming or processing it in some way. If you lose derived data,
you can re-create it from the original source. A classic example is a cache: data
can be served from the cache if present, but if the cache doesn’t contain what you
need, you can fall back to the underlying database. Denormalized values, indexes
and materialized views also fall in this category. In recommendation systems,
predictive summary data is often derived from usage logs.



**MapReduce**:  is a programming model and an associated implementation for processing and generating big data sets with a parallel, distributed algorithm on a cluster. A MapReduce program is composed of a map procedure, which performs filtering and sorting, and a reduce method


## Batch Processing
Let’s distinguish three different types of system:
* Services (online systems)
* Batch processing systems (offline systems)
    - A batch processing system takes a large amount of input data, runs a job to pro‐
cess it, and produces some output data. Jobs often take a while (from a few
minutes to several days)
* Stream processing systems (near-real-time systems)
    - Stream processing is somewhere between online and offline/batch (so it is some‐
times called near-real-time or nearline processing).

batch processing is an important building block in our
quest to build reliable, scalable and maintainable applications. For example, Map‐
Reduce, a batch-processing algorithm published in 2004  was (perhaps over-
enthusiastically) called “the algorithm that makes Google so massively scalable” . It
was subsequently implemented in various open source data systems, including
Hadoop, CouchDB and MongoDB