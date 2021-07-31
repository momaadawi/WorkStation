#### Hardware faults
    pass
#### Software faults
    pass

#### Human errors
*   Design  systems  in  a  way  that  minimizes  opportunities  for  error.  For  example,
well-designed  abstractions,  APIs  and  admin  interfaces  make  it  easy  to  do  “the
right thing”
*   Decouple the places where people make the most mistakes from the places where
they  can  cause  failure, (provide  fully-featured  non-production
sandbox  environments  where  people  can  explore  and  experiment  safely,  using
real data, without affecting real users)
*   Test thoroughly at all levels, from unit tests to whole-system integration tests and
manual  tests 
*   allow quick and easy recovery from human errors, to minimize the impact in the
case of a failure. For example, make it fast to roll back configuration changes
*   Set  up  detailed  and  clear  monitoring,  such  as  performance  metrics  and  error
rates