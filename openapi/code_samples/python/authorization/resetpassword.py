import requests
import json

url = "https://api.tizo.co/api/v1/auth/reset-password/"

payload = json.dumps({
  "password": "12",
  "oldPassword": "a"
})
headers = {
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
