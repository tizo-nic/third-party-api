var client = new RestClient("http://staging-api.tizo.co/api/v1/delivery/pricing/create");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""idStore"": 1," + "\n" +
@"    ""idBranchStore"": 1," + "\n" +
@"    ""description"": ""Envío desde la App""," + "\n" +
@"    ""waypoints"": [" + "\n" +
@"        {" + "\n" +
@"            ""type"": ""PICK_UP""," + "\n" +
@"            ""city"": ""Managua""," + "\n" +
@"            ""country"": ""Nicaragua""," + "\n" +
@"            ""state"": ""Managua""," + "\n" +
@"            ""addressStreet"": ""Calle María de los Ángeles""," + "\n" +
@"            ""personName"": ""Otto de la Rocha""," + "\n" +
@"            ""personIdentification"": ""001-060606-1010A""," + "\n" +
@"            ""phone"": ""50588888888""," + "\n" +
@"            ""addressHuman"": ""Frente a la iglesia""," + "\n" +
@"            ""addressGeo"": ""Calle María de los Ángeles, Managua, Nicaragua""," + "\n" +
@"            ""personEmail"": ""soyuncorreo@correo.com""," + "\n" +
@"            ""instructions"": ""Llamar al timbre""," + "\n" +
@"            ""latitude"": 12.123456," + "\n" +
@"            ""longitude"": -86.123456," + "\n" +
@"            ""reference"": 1" + "\n" +
@"        }" + "\n" +
@"    ]," + "\n" +
@"    ""items"": [" + "\n" +
@"        {" + "\n" +
@"            ""category"": 1," + "\n" +
@"            ""idCapacity"": 1," + "\n" +
@"            ""categoryOther"": ""Otro""," + "\n" +
@"            ""name"": ""Laptop""," + "\n" +
@"            ""description"": ""Laptop HP""," + "\n" +
@"            ""instructions"": ""No dejar en la puerta""," + "\n" +
@"            ""weight"": 1.5," + "\n" +
@"            ""height"": 1.5," + "\n" +
@"            ""depth"": 1.5," + "\n" +
@"            ""width"": 1.5," + "\n" +
@"            ""quantity"": 0," + "\n" +
@"            ""value"": 1.5," + "\n" +
@"            ""fragile"": true," + "\n" +
@"            ""document"": true," + "\n" +
@"            ""images"": [" + "\n" +
@"                ""https://tizo.com.mx/images/1.jpg""," + "\n" +
@"                ""https://tizo.com.mx/images/2.jpg""" + "\n" +
@"            ]" + "\n" +
@"        }" + "\n" +
@"    ]," + "\n" +
@"    ""customerName"": ""Agapito Díaz""," + "\n" +
@"    ""customerPhone"": ""5512345678""," + "\n" +
@"    ""customerEmail"": ""tucorreo@correo.com""," + "\n" +
@"    ""deliveryTime"": ""2022-04-22T12:10:32Z""," + "\n" +
@"    ""deliveryTimeInMilliseconds"": 1212121212," + "\n" +
@"    ""imagePreview"": ""https://www.google.com.mx/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png""," + "\n" +
@"    ""collectMoney"": 100," + "\n" +
@"    ""isTest"": false," + "\n" +
@"    ""lineBusiness"": ""LOGISTICS""," + "\n" +
@"    ""selectedMethod"": {" + "\n" +
@"        ""method"": ""DRIVER""," + "\n" +
@"        ""idCourier"": 1," + "\n" +
@"        ""idAreaOrigin"": 1," + "\n" +
@"        ""idAreaDestination"": 1," + "\n" +
@"        ""idPaymentMethod"": 1," + "\n" +
@"        ""idBranchOrigin"": 1," + "\n" +
@"        ""idBranchDestination"": 1," + "\n" +
@"        ""dateEstimatedInMilliseconds"": 1454545454," + "\n" +
@"        ""estimatedTimeInMilliseconds"": 1454545454," + "\n" +
@"        ""idCard"": 1," + "\n" +
@"        ""password"": ""1234""," + "\n" +
@"        ""card"": {" + "\n" +
@"            ""name"": ""Juan Perez""," + "\n" +
@"            ""number"": ""4111111111111111""," + "\n" +
@"            ""expirationDate"": ""1221""," + "\n" +
@"            ""cvv"": ""123""," + "\n" +
@"            ""debit"": true," + "\n" +
@"            ""empty"": true" + "\n" +
@"        }," + "\n" +
@"        ""cash"": {" + "\n" +
@"            ""cashAmount"": 100" + "\n" +
@"        }," + "\n" +
@"        ""invoice"": {" + "\n" +
@"            ""businessName"": ""CONSUMIDOR FINAL""," + "\n" +
@"            ""address"": ""CONSUMIDOR FINAL""," + "\n" +
@"            ""ruc"": ""CONSUMIDOR FINAL""," + "\n" +
@"            ""phone"": ""CONSUMIDOR FINAL""" + "\n" +
@"        }," + "\n" +
@"        ""coupon"": ""PRIMER_ENVIO""," + "\n" +
@"        ""estimateId"": ""121212""," + "\n" +
@"        ""deliveryOfferId"": ""121212""," + "\n" +
@"        ""transactionCode"": ""88185B37-FFC2-40AA-B204-398CFAD50788""," + "\n" +
@"        ""deliveryEstimatedToCalendar"": ""2024-08-09T21:20:57.089Z""" + "\n" +
@"    }," + "\n" +
@"    ""totalValue"": 0" + "\n" +
@"}";

request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);
