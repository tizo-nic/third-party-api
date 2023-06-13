import requests

url = "http://staging-api.tizo.co/api/v1/system-data/capacities/"

payload={}
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)
