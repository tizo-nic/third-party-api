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
    "preparationTimeType": "string",
    "preparationTimeDuration": 0,
    "specialTape": "string",
    "idCategory": 1,
    "idStore": 1,
    "idMotherCategory": 1,
    "returnReplacement": 0,
    "returnInterval": 0,
    "replacementInterval": 0,
    "digitalProductNote": 0,
    "idAlreadyExistProduct": 0,
    "digital": true,
    "selfPickup": true
  },
  "productOptionsPricing": [
    {
      "productOptionKeyValueInList": [
        {
          "idProductOptionKeyValue": 0,
          "key": "string",
          "value": "string"
        }
      ],
      "idProductOptions": 0,
      "idProductOptionsInventory": 0,
      "idBranch": 0,
      "quantity": 0,
      "cost": 0,
      "price": 0,
      "discountPercentage": 100,
      "tax": 0,
      "lotNumber": "string",
      "productOptionOfferInUpdatedDto": {
        "idProductOptionOffer": 0,
        "offer": 0,
        "endDate": "2024-09-12T16:43:35.344Z"
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
$request = new Request('PUT', 'https://staging-api.tizo.co/api/v1/products/update/product/{id}', $headers,$body);
$res = $client->sendAsync($request)->wait();
echo $res->getBody();
