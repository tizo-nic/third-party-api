<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg',
  'Content-Type' => 'application/json'
];
$body = '{
  "whatsapp": false,
  "sms": false,
  "email": true
}';
$request = new Request('PUT', 'https://staging-api.tizo.co/api/v1/delivery/send-notification/98871c18-a766-4b06-b528-f39d0b2666ba/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
