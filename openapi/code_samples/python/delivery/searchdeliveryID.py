import requests

url = "https://staging-api.tizo.co/api/v1/delivery/get/?idDelivery=304"

payload={}
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODE4MDY3MywiZXhwIjoxNjY4Nzg1NDczfQ.Epg1NeTr_R2de8jUQW-B2eJxyEFpC00CaJMmxsHHFbP9tkHBWhU7eTLIe47GHWchyy_-z-WthaloG92yFeblHg'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)

