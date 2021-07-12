from django import template

register = template.Library()

timeformat = ''

def mytag(oldavalue):
    return oldavalue.strftime(timeformat)