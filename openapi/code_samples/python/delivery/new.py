import requests
import json

url = "http://staging-api.tizo.co/api/v1/delivery/pricing/create"

payload = json.dumps({
                       "idStore": 1,
                       "idBranchStore": 1,
                       "description": "Envío desde la App",
                       "waypoints": [
                         {
                           "type": "PICK_UP",
                           "city": "Managua",
                           "country": "Nicaragua",
                           "state": "Managua",
                           "addressStreet": "Calle María de los Ángeles",
                           "personName": "Otto de la Rocha",
                           "personIdentification": "001-060606-1010A",
                           "phone": "50588888888",
                           "addressHuman": "Frente a la iglesia",
                           "addressGeo": "Calle María de los Ángeles, Managua, Nicaragua",
                           "personEmail": "soyuncorreo@correo.com",
                           "instructions": "Llamar al timbre",
                           "latitude": 12.123456,
                           "longitude": -86.123456,
                           "reference": 1
                         }
                       ],
                       "items": [
                         {
                           "category": 1,
                           "idCapacity": 1,
                           "categoryOther": "Otro",
                           "name": "Laptop",
                           "description": "Laptop HP",
                           "instructions": "No dejar en la puerta",
                           "weight": 1.5,
                           "height": 1.5,
                           "depth": 1.5,
                           "width": 1.5,
                           "quantity": 0,
                           "value": 1.5,
                           "fragile": true,
                           "document": true,
                           "images": [
                             "https://tizo.com.mx/images/1.jpg",
                             "https://tizo.com.mx/images/2.jpg"
                           ]
                         }
                       ],
                       "customerName": "Agapito Díaz",
                       "customerPhone": "5512345678",
                       "customerEmail": "tucorreo@correo.com",
                       "deliveryTime": "2022-04-22T12:10:32Z",
                       "collectMoney": 100,
                       "isTest": false,
                       "selectedMethod": {
                         "method": "DRIVER",
                         "idCourier": 1,
                         "idPaymentMethod": 1,
                         "card": {
                           "name": "Juan Perez",
                           "number": "4111111111111111",
                           "expirationDate": "1221",
                           "cvv": "123",
                           "debit": true,
                           "empty": true
                         },
                         "cash": {
                           "cashAmount": 100
                         },
                         "invoice": {
                           "businessName": "CONSUMIDOR FINAL",
                           "address": "CONSUMIDOR FINAL",
                           "ruc": "CONSUMIDOR FINAL",
                           "phone": "CONSUMIDOR FINAL"
                         },
                         "coupon": "PRIMER_ENVIO",
                         "estimateId": "121212",
                         "deliveryOfferId": "121212",
                       }
                     })
headers = {
  'Authorization': 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg',
  'Content-Type': 'application/json'
}

response = requests.request("POST", url, headers=headers, data=payload)

print(response.text)
