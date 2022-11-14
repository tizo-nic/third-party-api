<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODE3OTE2MywiZXhwIjoxNjY4NzgzOTYzfQ.NFIxkVowStlEtnDa2RXTKLGQWv844q5EPI3oBSkjGRlVz-jTd4IXSfl8byOpzZurm6ScyslhgJ_kjuJZTgFQFQ',
  'Content-Type' => 'application/json'
];
$body = '{
  "username": "store_11",
  "password": "12",
  "typeUser": "store_api"
}';
$request = new Request('POST', 'https://api.tizo.co/api/v1/auth/login/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
