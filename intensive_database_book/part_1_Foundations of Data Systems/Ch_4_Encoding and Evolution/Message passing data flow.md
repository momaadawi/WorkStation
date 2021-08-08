# Message passing data flow
Using a message broker has several advantages compared to direct RPC:
* it  can  act  as  a  buffer  if  the  recipient  is  unavailable  or  overloaded,  and  thus
improve system reliability
* it  can  automatically  redeliver  messages  to  a  process  that  crashed,  and  thus  pre‐
vent messages from being lost
* t  avoids  the  sender  needing  to  know  the  IP  address  and  port  number  of  the
recipient  (which  is  particularly  useful  in  a  “cloud”  deployment  where  virtual
machines often come and go)
* it allows one message to be sent to several recipients
* it  logically  decouples  the  sender  from  the  recipient  (the  sender  just  publishes
messages and doesn’t care who consumes them)

difference  compared  to  RPC  is  that  message-passing  communication  is
usually one-way.
a sender normally doesn’t expect to receive a reply to its messages. It
is possible for a process to send a response, but this would usually be done on a sepa‐
rate channel. This is what makes it asynchronous: the sender doesn’t wait for the mes‐
sage to be delivered, but simply sends it and then forgets about it.

## Message brokers
>
THIS SECTION NEED MORE STUDY, I WILL BE BACK SOON
>