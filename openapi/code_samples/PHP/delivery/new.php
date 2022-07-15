<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg',
  'Content-Type' => 'application/json'
];
$body = '{
  "description": "Con descripcion",
  "isTest": true,
  "deliveryTime": "2022-06-08T17:15:53Z",
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
      "category": 13,
      "name": "Paquete numero uno",
      "description": "Una escoba con gaseosa.",
      "weight": 50,
      "height": 50,
      "depth": 50,
      "width": 50,
      "value": 50,
      "fragile": false,
      "document": false,
      "images": [
        ".src",
        ".src"
      ]
    }
  ],
  "customerEmail": "agarciadarce@gmail.com",
  "selectedMethod": {
    "method": "COURIER",
    "idCourier": 0,
    "idAreaOrigin": 9,
    "idAreaDestination": 10,
    "idPaymentMethod": 2
  },
  "idStore": 2,
  "idBranchStore": 3
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/delivery/new/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();