<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg',
  'Content-Type' => 'application/json'
];
$body = '{
           "type": "string",
           "waypoints": [
             {
               "type": "string",
               "city": "string",
               "country": "string",
               "state": "string",
               "addressStreet": "string",
               "personName": "string",
               "personIdentification": "string",
               "phone": "string",
               "addressHuman": "string",
               "addressGeo": "string",
               "personEmail": "string",
               "instructions": "string",
               "latitude": 0,
               "longitude": 0
             }
           ],
           "items": [
             {
               "weight": 0,
               "height": 0,
               "width": 0,
               "depth": 0,
               "idItemCategory": 0,
               "idCapacity": 0,
               "value": 0,
               "fragile": true
             }
           ],
           "deliveryTime": "string",
           "isTest": true,
           "idStore": 0,
           "collectMoney": 0,
           "lineBusiness": "string"
         }';
$request = new Request('POST', 'http://staging-api.tizo.co/api/v1/delivery/estimate/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
