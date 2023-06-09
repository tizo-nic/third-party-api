import requests
import json

url = "https://staging-api.tizo.co/api/v1/auth/login/"

payload = json.dumps({
  "username": "store_11",
  "password": "12",
  "typeUser": "store_api"
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODE3OTE2MywiZXhwIjoxNjY4NzgzOTYzfQ.NFIxkVowStlEtnDa2RXTKLGQWv844q5EPI3oBSkjGRlVz-jTd4IXSfl8byOpzZurm6ScyslhgJ_kjuJZTgFQFQ',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
