import contextlib
import sys


@contextlib.contextmanager
def logging_context_manager():
    print('logging context manager: enter')
    try:
        yield 'you are in with-block!'
    except Exception:
        print('logging context manager: exceptional exit',
            sys.exc_info())
        raise 

#Using Multiple Context Manager test
@contextlib.contextmanager
def nest_test(name):
    print('Entering: ', name)
    yield 
    print('Existing: ', name)
