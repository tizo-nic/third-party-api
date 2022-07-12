<?php
$client = new Client();
$headers = [
  'Authorization' => '',
  'Content-Type' => 'application/json'
];
$body = '{
  "method": "email",
  "wordToMatch": "m_yoni3",
  "typeUser": "manager"
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/auth/recovery-password/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
