import requests
import json

url = "https://staging-api.tizo.co/api/v1/vendors/stores/0/notifications/"

payload = json.dumps({
  "productInfo": {
    "name": "string",
    "brand": "string",
    "shortDescription": "string",
    "longDescription": "string",
    "warranty": 0,
    "warrantyPdf": "string",
    "promotion": true,
    "preparationTimeType": "string",
    "preparationTimeDuration": 0,
    "specialTape": "string",
    "idCategory": 1,
    "idStore": 1,
    "idMotherCategory": 1,
    "returnReplacement": 0,
    "returnInterval": 0,
    "replacementInterval": 0,
    "digitalProductNote": 0,
    "idAlreadyExistProduct": 0,
    "digital": true,
    "selfPickup": true
  },
  "productOptionsPricing": [
    {
      "productOptionKeyValueInList": [
        {
          "key": "string",
          "value": "string"
        }
      ],
      "idBranch": 0,
      "quantity": 0,
      "cost": 0,
      "price": 0,
      "discountPercentage": 100,
      "tax": 0,
      "lotNumber": "string",
      "productOptionOfferIn": {
        "offer": 0,
        "endDate": "2024-09-12T15:56:16.287Z"
      },
      "width": 0,
      "height": 0,
      "weight": 0,
      "depth": 0,
      "digitalProductPathLink": "string",
      "skuCode": "string",
      "digitalProductQuantity": 0
    }
  ]
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)