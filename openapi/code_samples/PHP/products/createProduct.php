<?php
$client = new Client();
$headers = [
  'Authorization' => 'eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwNzUxMCwiZXhwIjoxNjU4NDEyMzEwfQ.ylwwULlL3I2oxBLvs9ydZtfNBm8VJIH7rUIetj0qMvlCHM51ReuwzEG4s7FuVuZiUCo3rA0suHV8VIAD_2j14g'
];
$body ='{
          "productInfo": {
            "name": "string",
            "brand": "string",
            "shortDescription": "string",
            "longDescription": "string",
            "warranty": 0,
            "warrantyPdf": "string",
            "promotion": true,
            "preparationTimeType": "Minuto",
            "preparationTimeDuration": 0,
            "specialTape": "string",
            "idCategory": 0,
            "idStore": 0,
            "returnInterval": 0,
            "replacementInterval": 0,
            "digitalProductNote": 0,
            "fileInventoryDtoList": [
              {
                "filePath": "string",
                "filesType": "Image"
              }
            ],
            "selfPickup": true
          },
          "productOptionsPricing": [
            {
              "productOptionKeyValueInList": [
                {
                  "key": "string",
                  "value": "string"
                }
              ],
              "idCapacity": 0,
              "productionQuantitiesList": [
                {
                  "idBranch": 0,
                  "quantity": 0
                }
              ],
              "cost": 0,
              "price": 0,
              "discountPercentage": 0,
              "lotNumber": "string",
              "productOptionOfferIn": {
                "offer": 0,
                "endDate": "2024-10-24T22:51:46.653Z"
              },
              "width": 0,
              "height": 0,
              "weight": 0,
              "depth": 0,
              "digitalProductPathLink": "string",
              "skuCode": "string",
              "digitalProductQuantity": 0
            }
          ]
        }';
$request = new Request('POST', 'https://staging-api.tizo.co/api/v1/products/create/', $headers,$body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
