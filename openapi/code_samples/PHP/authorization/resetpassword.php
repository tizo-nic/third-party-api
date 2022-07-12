<?php
$client = new Client();
$headers = [
  'Content-Type' => 'application/json'
];
$body = '{
  "password": "12",
  "oldPassword": "a"
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/auth/reset-password/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
