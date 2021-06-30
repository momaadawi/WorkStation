### Contextlib
standard library module that provide utitlities for common tasks involving the with statment

#### context manager decorator
is a decorator for creating new context manager

#### Concepts
*   to use contextmangerDecorator you first create generator which used yield instead of return
*   Decorate the generator with context manager to create  a context manager factory function 

``` python
@contextlib.contextmanager
def my_context_manager():
    #<ENTER>
    try: 
        yield [value]
        #<NORMAL EXIT>
    except: 
        #<EXCEOTIONAL EXIT>
        raise

with my_context_manager() as x:
    #...
```

#### Benefits of generator 
*   using generator avoid the need of break context manager logic across two methods
*   since generatos remember their state, they can mbe used to implement statement context manager

#### Exception propagation
*   Use normal exception handling to control exception propagation
*   Re-raise or not catching an exception will not propagate it out of the with-statement
*   Catching and not re-raise it will not propgate the exception


#### Using Multiple Context Manager
``` python
with cm1() as a, cm() as b: 
    #BODY
```

