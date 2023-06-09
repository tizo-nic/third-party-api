<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODMyNzMzMywiZXhwIjoxNjU4OTMyMTMzfQ.JB8oNrBgDqQyymETvZBarNQjs6vRx-zdwVnGvjlqLdB7GgtI8B-yj7haPdqG0OSrFltgMp2HN5msNR268qJlxw'
];
$request = new Request('GET', 'https://staging-api.tizo.co/api/v1/vendors/stores/0/credit-bag/', $headers);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
