from django.http.response import JsonResponse
from django.shortcuts import render
from django.http import HttpResponse
from datetime import datetime
from meetings.models import Meeting

# Create your views here.
def welcome(request) -> HttpResponse:
    return render(request, "website/welcome.html", {"meetings": Meeting.objects.all()})

def date(request):
    return HttpResponse(f"this page was served at: {datetime.now()}") 

