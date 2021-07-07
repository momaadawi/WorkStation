from meetings.models import Meeting, Room
from django.shortcuts import get_object_or_404, render

# Create your views here.
def detail(request, id: int):
    meeting = get_object_or_404(Meeting, pk=id)    
    return render(request, "meetings/detail.html", {"meeting": meeting}) 


def room_list(request):
    return render(request, "meetings/rooms_list.html", { "rooms" :  Room.objects.all()})