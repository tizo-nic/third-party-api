import requests

url = "{{base_url}}/api/v1/system-data/banks/0/"

payload={}
headers = {
  'Authorization': '{{auth_token}}'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)