<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw',
  'Content-Type' => 'application/json'
];
$body = '{
  "sendEmail": 1,
  "sendSms": 1,
  "sendWhatsapp": 1,
  "sendPush": 1,
  "sendTelegram": 1
}';
$request = new Request('POST', 'https://staging-api.tizo.co/api/v1/vendors/stores/0/notifications/', $headers, $body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();