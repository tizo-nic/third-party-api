import requests
import json

url = "https://api.tizo.co/api/v1/vendors/stores/0/branches/1/"

payload = json.dumps({
  "name": "strong",
  "idMunicipality": 1,
  "addressGeo": "strong",
  "addressHuman": "strong",
  "latitude": 12.3663,
  "longitude": 14.2222,
  "active": True
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw',
  'Content-Type': 'application/json'
}

response = requests.request("PUT", url, headers=headers, data=payload)

print(response.text)