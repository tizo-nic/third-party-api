<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw',
  'Content-Type' => 'application/json'
];
$body = '{
  "name": "string",
  "idMunicipality": 0,
  "addressGeo": "string",
  "addressHuman": "string",
  "latitude": 0,
  "longitude": 0,
  "active": true,
  "vacation": true
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/vendors/stores/:idStore/branches/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
