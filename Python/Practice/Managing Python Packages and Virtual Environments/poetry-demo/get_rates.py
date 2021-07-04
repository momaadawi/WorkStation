import requests
from box import Box

response = requests.get("https://api.exchangeratesapi.io/latest?symbols=USD")
print(response.text)