class LevelOrderIterator:
    def __init__(self, squence):
        self._sequence = squence
        self._index = 0
        
    def __next__(self):
        if self._index >= len(self._sequence):
            raise StopIteration
        result = self._sequence[self._index]
        self._index += 1
        return result

    def __iter__(self):
        return self

    def _is_perfect_length(sequence):
        """ true if squence has 2^n - 1
        """
        n = len(sequence)
        return ((n + 1) & n == 0) and (n != 0)