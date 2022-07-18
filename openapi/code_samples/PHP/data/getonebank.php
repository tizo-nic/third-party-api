<?php
$client = new Client();
$headers = [
  'Authorization' => '{{auth_token}}'
];
$request = new Request('GET', '{{base_url}}/api/v1/system-data/banks/0/', $headers);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
