<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8yIiwiaWF0IjoxNjY4MTc3Mjc2LCJleHAiOjE2Njg3ODIwNzZ9.OKgtyp6DYHkANu-s-BZaHj1jAs0d6Pq37_3hiPm1C2EQ6XxHwpzN36FZsG5o0L29lno7Qryt3gFn4GfzVdETyA',
  'Content-Type' => 'application/json'
];
$body = '{
  "password": "12",
  "oldPassword": "1"
}';
$request = new Request('POST', 'https://staging-api.tizo.co/api/v1/auth/reset-password/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
