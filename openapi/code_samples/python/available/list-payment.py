import requests

url = "https://api.tizo.co/api/v1/vendors/stores/2/payment-available/"

payload={}
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwNzUxMCwiZXhwIjoxNjU4NDEyMzEwfQ.ylwwULlL3I2oxBLvs9ydZtfNBm8VJIH7rUIetj0qMvlCHM51ReuwzEG4s7FuVuZiUCo3rA0suHV8VIAD_2j14g'
}

response = requests.request("GET", url, headers=headers, data=payload)

print(response.text)
