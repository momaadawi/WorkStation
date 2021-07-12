from django.http import HttpResponse
from django.http.response import JsonResponse
from django.shortcuts import render
from .models import Ticket

def index(request):
    return render(request, 'home.html')
def layout(request):
    return render(request, 'applayout.html')



def submit(request):
    if request.method == 'POST':
        body = request.POST.get('body')
        submmitter = request.POST.get('submmitter')
        tickets = Ticket(submmitter = submmitter, body = body)
        tickets.save()
    return render(request, 'submit.html')

def tickets(request):
    all_tickets = Ticket.objects.all()
    return render(request, 'tickets.html', {'tickets': all_tickets})

def tickets_raw(request):
    tickets = list(Ticket.objects.values())
    return JsonResponse(tickets, safe=False)


def ticket(request, id):
    ticket = Ticket.objects.get(pk=id)
    return render(request, 'ticket.html', {'ticket': ticket})