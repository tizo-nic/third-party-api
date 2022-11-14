import requests
import json

url = "https://api.tizo.co/api/v1/auth/recovery-password/"

payload = json.dumps({
  "method": "email",
  "wordToMatch": "m_yoni3",
  "typeUser": "manager"
})
headers = {
  'Authorization': '',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)