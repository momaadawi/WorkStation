import math


def triangle_area(a, b, c):
    sides = sorted((a, b, c))

    if sides[2] > sides[0] + sides[1]:
        raise TriangleError('Ilegal Triangle', sides)

    p = (a+b+c) / 2
    a = math.sqrt(p*(p-a) * (p-b) * (p-c))
    return a

def main():
    try: 
        a= triangle_area(3,4,10)
        print(a)
    except  TriangleError as e:
        print(e)

class TriangleError(Exception):
    def __init__(self, text, sides) :
        super().__init__(text)
        self._sides = tuple(sides)

    @property
    def sides(self):
        return self._sides

    def __str__(self):
        return "{} fro sides {}".format(self.args[0], self._sides )
