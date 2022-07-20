import requests
import json

url = "https://api.tizo.co/api/v1/vendors/stores/"

payload = json.dumps({
  "name": "TADA",
  "ruc": "12121",
  "email": "agarciadarce@gmail.com",
  "dba": "AA",
  "isPrivate": True,
  "pathImage": "",
  "phone": "+50587878787",
  "description": "AA",
  "vacation": False
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
