<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg',
  'Content-Type' => 'application/json'
];
$body = '{
  "idStore": 0,
  "idBranchStore": 1,
  "customerEmail": "agb@tizo.app",
  "deliveryTypeCode": "T1",
  "description": "Envío simple",
  "isTest": false,
  "items": [
    {
      "fragile": true,
      "document": false,
      "idItemCategory": 29,
      "categoryOther": "",
      "value": 81,
      "description": "cal",
      "width": 45,
      "height": 16,
      "depth": 35,
      "weight": 5,
      "name": "Paquete",
      "category": 29,
      "images": [],
      "nameCategory": "Calzado"
    }
  ],
  "selectedMethod": {
    "method": "COURIER",
    "idCourier": 26,
    "idAreaOrigin": 2380,
    "idAreaDestination": 2385,
    "idBranchOrigin": -1,
    "idBranchDestination": -1,
    "idPaymentMethod": 4
  },
  "waypoints": [
    {
      "type": "PICK_UP",
      "city": "Managua",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "Sede Central",
      "personName": "Luis Gonzalez Lopez",
      "personEmail": "agb@tizo.app",
      "personIdentification": "001-4430696-0016J",
      "phone": "+50563397024",
      "addressHuman": "Parque Central",
      "addressGeo": "4QRG+622, Managua, Nicaragua",
      "instructions": "Entrar y retirar en tienda",
      "latitude": 12.140644111,
      "longitude": -86.225119053,
      "branchName": "Sede Central",
      "storeName": "tizo"
    },
    {
      "type": "DROP_OFF",
      "city": "Tipitapa",
      "country": "Nicaragua",
      "state": "Managua",
      "addressStreet": "Vía sin nombre",
      "personName": "Axel Garcia",
      "personEmail": "axel.garcia@tizo.app",
      "personIdentification": "0010611991009L",
      "phone": "+50581380937",
      "addressHuman": "Contiguo al Hospital Vivian Pellas",
      "addressGeo": "5W42+2J Tipitapa, Nicaragua",
      "instructions": "Entregar al cliente",
      "latitude": 12.155067762636003,
      "longitude": -86.09838499989073,
      "isSaveCustomer": false,
      "fullName": "Axel Garcia",
      "url": {
        "url": "assets/img/logistic/maps/B-icon.png",
        "scaledSize": {
          "width": 60,
          "height": 60
        }
      }
    }
  ]
}';
$request = new Request('POST', 'http://staging-api.tizo.co/api/v1/delivery/pricing/create/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
