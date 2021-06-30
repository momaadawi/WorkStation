class LoggingContextManager:

    def __enter__(self):
        print('LoggingContextManager.__enter__()')
        return 'you are in with-block'

    def __exit__(self, exc_type, exc_value, traceback):
        if exc_type is None:
            print('LggingContextManager.__exit__: '
            'Normal Exit Detected')           
        else:
            print('loggingContextManager.__exit__: '
            'Exception Detected'
            f'type = {exc_type}, value = {exc_value}, traceback = {traceback}')
        return 