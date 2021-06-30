import math

class InclinationError(Exception):
    pass

def inclination(dx, dy):
    try:
        return math.degrees(math.atan(dx/dy))
    except ZeroDivisionError as e:
        raise InclinationError('slope cant be vertical') from e

