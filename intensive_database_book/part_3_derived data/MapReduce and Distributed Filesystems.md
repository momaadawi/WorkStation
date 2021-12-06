# MapReduce and Distributed Filesystems
MapReduce is a bit like Unix tools, but distributed across potentially thousands of
machines. Like Unix tools, it is a fairly blunt, brute-force, but surprisingly effective
tool. A single MapReduce job is comparable to a single Unix process: it takes one or
more inputs and produces one or more outputs.

While Unix tools use stdin and stdout as input and output, MapReduce jobs read
and write files on a distributed filesystem. In Hadoop’s implementation of Map‐
Reduce, that filesystem is called HDFS (Hadoop Distributed FileSystem), an open
source re-implementation of Google’s GFS

HDFS has scaled well: at the time of writing, the biggest HDFS deployments run on
tens of thousands of machines, with combined storage capacity of hundreds of peta‐
bytes [ 21]. Such large scale has become viable because the cost of data storage and
access on HDFS, using commodity hardware and open source software, is much
lower than the equivalent capacity on a dedicated storage appliance [22].
Various other distributed filesystems besides HDFS exist, such as GlusterFS or the
Quantcast File System [ 23]. Object storage services such as Amazon S3, Azure Blob
Storage and OpenStack Swift [ 24] are similar in many ways. iv In this chapter we will
mostly use HDFS as running example, but the principles apply to any distributed file‐
system.

## MapReduce job execution
MapReduce is a programming framework with which you can write code to process
large datasets in a distributed filesystem like HDFS. The easiest way of understanding
it is by referring back to the web server log analysis example in  The pattern of data processing in MapReduce is very similar to this

* Map
    - The map function is called once for every input record, and its job is to extract the key and value from the input record. In the web server log example, 

* Reduce
- The MapReduce framework collects all the key-value pairs with the same key,and calls the reduce function with an iterator over that collection of values with the same key.