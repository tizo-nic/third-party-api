import requests
import json

url = "https://api.tizo.co/api/v1/auth/login/"

payload = json.dumps({
  "username": "store_0",
  "password": "12",
  "typeUser": "store_api"
})
headers = {
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
