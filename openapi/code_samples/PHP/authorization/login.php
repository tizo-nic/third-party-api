<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8wIiwiaWF0IjoxNjU1Nzk3NjQ5LCJleHAiOjE2NTY0MDI0NDl9.s-1eTUqzDnmCW98yN4CkFUNjkj_eCzjBe8qUHmO3GUcR35z-4i8o3MGzzEj-JztUcfewI1Sfm18HfPDA3IUR_Q',
  'Content-Type' => 'application/json'
];
$body = '{
  "username": "store_0",
  "password": "12",
  "typeUser": "store_api"
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/auth/login/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
