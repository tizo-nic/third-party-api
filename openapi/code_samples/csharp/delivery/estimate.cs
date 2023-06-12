var client = new RestClient("http://staging-api.tizo.co/api/v1/delivery/estimate/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""idStore"": 0,
" + "\n" +
@"    ""idBranchStore"": 1,
" + "\n" +
@"    ""customerEmail"": ""agb@tizo.app"",
" + "\n" +
@"    ""deliveryTypeCode"": ""T1"",
" + "\n" +
@"    ""description"": ""Envío simple"",
" + "\n" +
@"    ""isTest"": false,
" + "\n" +
@"    ""items"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""fragile"": false,
" + "\n" +
@"            ""document"": false,
" + "\n" +
@"            ""idItemCategory"": 29,
" + "\n" +
@"            ""categoryOther"": """",
" + "\n" +
@"            ""value"": 123,
" + "\n" +
@"            ""description"": ""dd"",
" + "\n" +
@"            ""width"": 45,
" + "\n" +
@"            ""height"": 16,
" + "\n" +
@"            ""depth"": 35,
" + "\n" +
@"            ""weight"": 5,
" + "\n" +
@"            ""name"": ""Paquete"",
" + "\n" +
@"            ""category"": 29,
" + "\n" +
@"            ""images"": [],
" + "\n" +
@"            ""nameCategory"": ""Calzado""
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""waypoints"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""type"": ""PICK_UP"",
" + "\n" +
@"            ""city"": ""Managua"",
" + "\n" +
@"            ""country"": ""Nicaragua"",
" + "\n" +
@"            ""state"": ""Managua"",
" + "\n" +
@"            ""addressStreet"": ""Sede Central"",
" + "\n" +
@"            ""personName"": ""Luis Gonzalez Lopez"",
" + "\n" +
@"            ""personEmail"": ""agb@tizo.app"",
" + "\n" +
@"            ""personIdentification"": ""001-4430696-0016J"",
" + "\n" +
@"            ""phone"": ""+50563397024"",
" + "\n" +
@"            ""addressHuman"": ""Parque Central"",
" + "\n" +
@"            ""addressGeo"": ""4QRG+622, Managua, Nicaragua"",
" + "\n" +
@"            ""instructions"": ""Entrar y retirar en tienda"",
" + "\n" +
@"            ""latitude"": 12.140644111,
" + "\n" +
@"            ""longitude"": -86.225119053,
" + "\n" +
@"            ""branchName"": ""Sede Central"",
" + "\n" +
@"            ""storeName"": ""tizo""
" + "\n" +
@"        },
" + "\n" +
@"        {
" + "\n" +
@"            ""type"": ""DROP_OFF"",
" + "\n" +
@"            ""city"": ""Tipitapa"",
" + "\n" +
@"            ""country"": ""Nicaragua"",
" + "\n" +
@"            ""state"": ""Managua"",
" + "\n" +
@"            ""addressStreet"": ""Vía sin nombre"",
" + "\n" +
@"            ""personName"": ""Axel Garcia"",
" + "\n" +
@"            ""personEmail"": ""axel.garcia@tizo.app"",
" + "\n" +
@"            ""personIdentification"": ""0010611991009L"",
" + "\n" +
@"            ""phone"": ""+50581380937"",
" + "\n" +
@"            ""addressHuman"": ""Contiguo al Hospital Vivian Pellas"",
" + "\n" +
@"            ""addressGeo"": ""5W42+2J Tipitapa, Nicaragua"",
" + "\n" +
@"            ""instructions"": ""Entregar al cliente"",
" + "\n" +
@"            ""latitude"": 12.155067762636003,
" + "\n" +
@"            ""longitude"": -86.09838499989073,
" + "\n" +
@"            ""isSaveCustomer"": false,
" + "\n" +
@"            ""fullName"": ""Axel Garcia"",
" + "\n" +
@"            ""url"": {
" + "\n" +
@"                ""url"": ""assets/img/logistic/maps/B-icon.png"",
" + "\n" +
@"                ""scaledSize"": {
" + "\n" +
@"                    ""width"": 60,
" + "\n" +
@"                    ""height"": 60
" + "\n" +
@"                }
" + "\n" +
@"            }
" + "\n" +
@"        }
" + "\n" +
@"    ]
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);