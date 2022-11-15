import requests
import json

url = "http://ac50c79e407e44dc89f257057d60ddbf-1643442314.us-east-1.elb.amazonaws.com/api/v1/delivery/new/"

payload = json.dumps({
  "description": "Con descripcion",
  "isTest": True,
  "deliveryTime": "2022-06-08T17:15:53Z",
  "waypoints": [
    {
      "type": "PICK_UP",
      "city": "Managua",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "tizo central",
      "personName": "Adriana",
      "personEmail": "agb@tizo.app",
      "personIdentification": "001-030696-0016J",
      "phone": "+50557418465",
      "addressHuman": "Bodegon mercado oriental",
      "addressGeo": "4P8V+8C8, Managua 14031, Nicaragua",
      "instructions": "No golpear",
      "latitude": 12.116088834,
      "longitude": -86.25661897,
      "branchName": "tizo central",
      "storeName": "Tizo bodegon"
    },
    {
      "type": "DROP_OFF",
      "city": "Managua",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "",
      "personName": "Hanzel Urrutia",
      "personEmail": "hanzelurrutia8118@gmail.com",
      "personIdentification": "888-170702-1002A",
      "phone": "+50578849074",
      "addressHuman": "Del molino, una cuadra arriba dos y medía al algo",
      "addressGeo": "514 P.º las colinas, Managua 14197, Nicaragua",
      "instructions": "Decir buenas",
      "latitude": 12.102190263,
      "longitude": -86.23643979
    }
  ],
  "items": [
    {
      "name": "Paquete",
      "fragile": False,
      "document": False,
      "description": "m",
      "isUsingCapacities": False,
      "value": 5,
      "weight": 50,
      "height": 30,
      "width": 40,
      "depth": 30,
      "images": [
        None
      ],
      "idItemCategory": 0,
      "capacitySelected": "Tizo Small",
      "otherCapacity": "m",
      "category": 0
    }
  ],
  "customerEmail": "agarciadarce@gmail.com",
  "selectedMethod": {
    "method": "COURIER",
    "idCourier": 1,
    "idPaymentMethod": 2
  },
  "idStore": 11,
  "idBranchStore": 20
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODUyNTU3NSwiZXhwIjoxNjczODA5NTc1fQ.8WAs-muUnBUrEIv4cevePavSOo_vVLS-jySkDF7tjVOgVo8mTg-NoMzb7OW7JbBBoIL_8L0CJfkkTLFVq5myYg',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
