import requests

url = "https://api.tizo.co/api/v1/auth/permissions/"

payload = ""
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzY0NzM4NSwiZXhwIjoxNjU4MjUyMTg1fQ.H9utsN8UrmnGR-_xiMe4kr4S0g82f5ejGPwmJowwcdWexxGjlhhAavOLJXylwRKwsAaaTL524eWU8dezi6x8tA'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)
