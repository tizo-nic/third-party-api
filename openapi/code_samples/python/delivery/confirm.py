import requests
import json

url = "https://api.tizo.co/api/v1/delivery/confirm/6ce15dac-83d2-4631-a32d-12b753da8fbc"

payload = json.dumps({})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)