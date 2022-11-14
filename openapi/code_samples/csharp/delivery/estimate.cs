var client = new RestClient("https://api.tizo.co/api/v1/delivery/estimate/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODQzODYyNywiZXhwIjoxNjY5MDQzNDI3fQ.DK3uGNDCZi9_pyJzhhMoujy1OCW0RHjL8sY1CnimwPSWJZ1Sbzhz4oyIK379Ei7jb0rbxHP7GuSGKpFJavyxMw");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""description"": ""Sin descripcion"",
" + "\n" +
@"    ""isTest"": true,
" + "\n" +
@"    ""idStore"": 2,
" + "\n" +
@"    ""idBranchStore"": 2,
" + "\n" +
@"    ""deliveryTime"": ""2022-06-05T23:15:53Z"",
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
@"            ""addressStreet"": ""Miguel Gutierrez"",
" + "\n" +
@"            ""personName"": ""Axel Garcia"",
" + "\n" +
@"            ""personIdentification"": ""001-061199-1009L"",
" + "\n" +
@"            ""phone"": ""+50581380937"",
" + "\n" +
@"            ""personEmail"": ""axelgarciadarce@gmail.com"",
" + "\n" +
@"            ""addressHuman"": ""Tamarindo"",
" + "\n" +
@"            ""addressGeo"": ""Jocote"",
" + "\n" +
@"            ""instructions"": ""Arbol de mango"",
" + "\n" +
@"            ""latitude"": 12.0985803,
" + "\n" +
@"            ""longitude"": -86.2275385
" + "\n" +
@"        },
" + "\n" +
@"        {
" + "\n" +
@"            ""city"": ""Managua"",
" + "\n" +
@"            ""country"": ""Nicaragua"",
" + "\n" +
@"            ""state"": ""Managua"",
" + "\n" +
@"            ""addressStreet"": ""9 de Junio"",
" + "\n" +
@"            ""personName"": ""Raul"",
" + "\n" +
@"            ""personEmail"": ""axel.garcia@tizo.app"",
" + "\n" +
@"            ""personIdentification"": ""001-061199-1009L"",
" + "\n" +
@"            ""phone"": ""+50558400760"",
" + "\n" +
@"            ""addressHuman"": ""Tamarindo"",
" + "\n" +
@"            ""addressGeo"": ""Jocote con maiz"",
" + "\n" +
@"            ""instructions"": ""Abajo del mercado"",
" + "\n" +
@"            ""type"": ""DROP_OFF"",
" + "\n" +
@"            ""longitude"": -86.235741,
" + "\n" +
@"            ""latitude"": 12.136511
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""items"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""category"": 12,
" + "\n" +
@"            ""name"": ""Paquete numero uno"",
" + "\n" +
@"            ""description"": ""Una escoba con gaseosa."",
" + "\n" +
@"            ""weight"": 1,
" + "\n" +
@"            ""height"": 1,
" + "\n" +
@"            ""depth"": 1,
" + "\n" +
@"            ""width"": 1,
" + "\n" +
@"            ""value"": 50,
" + "\n" +
@"            ""fragile"": false,
" + "\n" +
@"            ""document"": false,
" + "\n" +
@"            ""images"": [
" + "\n" +
@"                "".src"",
" + "\n" +
@"                "".src""
" + "\n" +
@"            ]
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""customerEmail"": ""agarciadarce@gmail.com""
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);