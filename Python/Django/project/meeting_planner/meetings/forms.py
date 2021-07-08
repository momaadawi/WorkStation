
from datetime import datetime
from django.core.exceptions import ValidationError
from django.forms import ModelForm, DateInput, TimeInput, TextInput


from .models import Meeting

class MeetingForm(ModelForm):
    class Meta:
        model = Meeting
        fields = '__all__'
        widgets = {
            'date': DateInput(attrs={"type": "date"}),
            'start': TimeInput(attrs={"type": "time"}),
            'duration': TextInput(attrs={"type": "number", "min": "1", "max": "4"})
        }

    def __clean__(self):
        date = self.cleaned_data.get('date')
        if date < datetime.today():
            raise ValidationError("Meetings cannot be in the past")
        return date
