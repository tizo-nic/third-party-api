import requests
import json

url = "https://api.tizo.co/api/v1/delivery/estimate/"

payload = json.dumps({
  "description": "Sin descripcion",
  "isTest": True,
  "idStore": 2,
  "idBranchStore": 2,
  "deliveryTime": "2022-06-05T23:15:53Z",
  "waypoints": [
    {
      "type": "PICK_UP",
      "city": "Managua",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "Miguel Gutierrez",
      "personName": "Axel Garcia",
      "personIdentification": "001-061199-1009L",
      "phone": "+50581380937",
      "personEmail": "axelgarciadarce@gmail.com",
      "addressHuman": "Tamarindo",
      "addressGeo": "Jocote",
      "instructions": "Arbol de mango",
      "latitude": 12.0985803,
      "longitude": -86.2275385
    },
    {
      "city": "Managua",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "9 de Junio",
      "personName": "Raul",
      "personEmail": "axel.garcia@tizo.app",
      "personIdentification": "001-061199-1009L",
      "phone": "+50558400760",
      "addressHuman": "Tamarindo",
      "addressGeo": "Jocote con maiz",
      "instructions": "Abajo del mercado",
      "type": "DROP_OFF",
      "longitude": -86.235741,
      "latitude": 12.136511
    }
  ],
  "items": [
    {
      "category": 12,
      "name": "Paquete numero uno",
      "description": "Una escoba con gaseosa.",
      "weight": 1,
      "height": 1,
      "depth": 1,
      "width": 1,
      "value": 50,
      "fragile": False,
      "document": False,
      "images": [
        ".src",
        ".src"
      ]
    }
  ],
  "customerEmail": "agarciadarce@gmail.com"
})
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODQzODYyNywiZXhwIjoxNjY5MDQzNDI3fQ.DK3uGNDCZi9_pyJzhhMoujy1OCW0RHjL8sY1CnimwPSWJZ1Sbzhz4oyIK379Ei7jb0rbxHP7GuSGKpFJavyxMw',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
