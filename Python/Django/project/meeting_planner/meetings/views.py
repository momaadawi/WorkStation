from meetings.models import Meeting, Room
from django.shortcuts import get_object_or_404, redirect, render
from .forms import MeetingForm
# Create your views here.
def detail(request, id: int):
    meeting = get_object_or_404(Meeting, pk=id)    
    return render(request, "meetings/detail.html", {"meeting": meeting}) 


def room_list(request):
    return render(request, "meetings/rooms_list.html", { "rooms" :  Room.objects.all()})


def new(request):
    if request.method == "POST":
        form = MeetingForm(request.POST)
        if form.is_valid():
            form.save()
            return redirect('welcome')
    else:            
        form = MeetingForm()
        return render(request, "meetings/new.html", {"from": form})