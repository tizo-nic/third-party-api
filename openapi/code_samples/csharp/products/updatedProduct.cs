var client = new RestClient("https://staging-api.tizo.co/api/v1/products/create");
client.Timeout = -1;
var request = new RestRequest(Method.PUT);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +
@"  ""name"": ""string""," + "\n" +
@"  ""brand"": ""string""," + "\n" +
@"  ""shortDescription"": ""string""," + "\n" +
@"  ""longDescription"": ""string""," + "\n" +
@"  ""warranty"": 0," + "\n" +
@"  ""warrantyPdf"": ""string""," + "\n" +
@"  ""promotion"": true," + "\n" +
@"  ""preparationTimeType"": ""string""," + "\n" +
@"  ""preparationTimeDuration"": 0," + "\n" +
@"  ""specialTape"": ""string""," + "\n" +
@"  ""idCategory"": 1," + "\n" +
@"  ""returnReplacement"": 0," + "\n" +
@"  ""returnInterval"": 0," + "\n" +
@"  ""replacementInterval"": 0," + "\n" +
@"  ""isDigital"": true," + "\n" +
@"  ""digitalProductNote"": 0," + "\n" +
@"  ""isSelfPickup"": true," + "\n" +
@"  ""idAlreadyExistProduct"": 0," + "\n" +
@"  ""productOptionsPricing"": [" + "\n" +
@"    {" + "\n" +
@"      ""productOptionKeyValueInList"": [" + "\n" +
@"        {" + "\n" +
@"          ""idProductOptionKeyValue"": 0," + "\n" +
@"          ""key"": ""string""," + "\n" +
@"          ""value"": ""string""" + "\n" +
@"        }" + "\n" +
@"      ]," + "\n" +
@"      ""idProductOptions"": 0," + "\n" +
@"      ""idProductOptionsInventory"": 0," + "\n" +
@"      ""idBranch"": 0," + "\n" +
@"      ""quantity"": 0," + "\n" +
@"      ""cost"": 0," + "\n" +
@"      ""price"": 0," + "\n" +
@"      ""discountPercentage"": 100," + "\n" +
@"      ""tax"": 0," + "\n" +
@"      ""lotNumber"": ""string""," + "\n" +
@"      ""productOptionOfferInUpdatedDto"": {" + "\n" +
@"        ""idProductOptionOffer"": 0," + "\n" +
@"        ""offer"": 0," + "\n" +
@"        ""endDate"": ""2024-09-12T16:50:51.282Z""" + "\n" +
@"      }," + "\n" +
@"      ""width"": 0," + "\n" +
@"      ""height"": 0," + "\n" +
@"      ""weight"": 0," + "\n" +
@"      ""depth"": 0," + "\n" +
@"      ""digitalProductPathLink"": ""string""," + "\n" +
@"      ""skuCode"": ""string""," + "\n" +
@"      ""digitalProductQuantity"": 0" + "\n" +
@"    }" + "\n" +
@"  ]" + "\n" +
@"}";

request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);