* With  server-side  applications  you  may  want  to  perform  a  rolling  upgrade  (also
known  as  staged  rollout) — deploying  the  new  version  to  a  few  nodes  at  a  time,
checking  whether  the  new  version  is  running  smoothly,  and  gradually  working
your way through all the nodes. This allows new versions to be deployed without
service downtime, and thus encourages more frequent releases and better evolva‐
bility.
* With client-side applications you’re at the mercy of the user, who may not install the update for some time.

This  means  that  old  and  new  versions  of  the  code,  and  old  and  new  data  formats,
may potentially all coexist in the system at the same time. In order for the system to
continue running smoothly, we need to maintain compatibility in both directions:

**Backward compatibility**:
>
Newer code can read data that was written by older code.
>

**Forward compatibility**:
>
Older code can read data that was written by newer code.
>

# Formats for Encoding Data
* When  you  want  to  write  data  to  a  file,  or  send  it  over  the  network,  you  have  to
encode it as some kind of self-contained sequence of bytes (for example, a JSON document).  Since  a  pointer wouldn’t  make  sense  to  any  other  process.
* we need some kind of translation between the two representations. The translation from the in-memory representation to a byte sequence is called encoding (also known  as  **serialization  or  marshalling**),  and  the  reverse  is  called  decoding  (**parsing, deserialization, unmarshalling**).

## Language-specific formats
pass
## JSON, XML and binary variants
* JSON distinguishes strings and numbers,  but  it  doesn’t  distinguish  integers  and  floating-point
* JSON  and  XML  have  good  support  for  Unicode  character  strings,  i.e.  human readable text, but they don’t support binary strings (sequences of bytes without a character encoding).
### Binary encoding
For data that is used only internally within your organization, there is less pressure to use a lowest-common-denominator encoding format. 
* You could choose a  format  that  is  more  compact  or  faster  to  parse.  For  a  small  dataset,  the gains  are negligible, but once you get into the terabytes, the choice of data format can have a big impact.

>
a binary encoding in json : {MessagePack, BSON, BJSON, UBJSON, BISON}
>

### Thrift and Protocol Buffers
Apache  Thrift and  Protocol  Buffers  are  binary  encoding  libraries  that  are
based  on  the  same  principle.  Protocol  Buffers  was  originally  developed  at  Google,
Thrift  was  originally  developed  at  Facebook,  and  both  were  made  open  source  in
2007-08
* Both  Thrift  and  Protocol  Buffers  require  a  schema  for  any  data  that  is  encoded
### Avro
pass
### The merits of schemas
pass

# Modes of Data Flow
