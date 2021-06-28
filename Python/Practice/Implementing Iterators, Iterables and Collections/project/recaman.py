from itertools import count

def recaman():
    """Generate Recaman's sequence.
    
    https://en.wikipedia.org/wiki/Recamán%27s_sequence
    https://oeis.org/A005132
    """
    seen = set()
    a = 0
    for n in count(1):
        yield a
        seen.add(a)
        c = a - n
        if c < 0 or c in seen:
            c = a + n
        a = c
