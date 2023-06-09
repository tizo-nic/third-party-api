import requests
import json

url = "https://staging-api.tizo.co/api/v1/vendors/stores/0/"

payload = json.dumps({
  "active": True
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODMyNzMzMywiZXhwIjoxNjU4OTMyMTMzfQ.JB8oNrBgDqQyymETvZBarNQjs6vRx-zdwVnGvjlqLdB7GgtI8B-yj7haPdqG0OSrFltgMp2HN5msNR268qJlxw',
  'Content-Type': 'application/json'
}

response = requests.request("PUT", url, headers=headers, data=payload)

print(response.text)