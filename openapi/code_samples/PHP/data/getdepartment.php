<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8yIiwiaWF0IjoxNjU4MTU0Mjc3LCJleHAiOjE2NTg3NTkwNzd9.u6b7ap-7vYikiIBwJ8ugj7rTM_0nVkuMXVlI-Mz7ayXmPT661F9--p-QfbcOcPtewQliHWqktS5P8YYNgPH3uA'
];
$request = new Request('GET', 'https://staging-api.tizo.co/api/v1/system-data/departments/3/', $headers);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();