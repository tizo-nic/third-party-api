var client = new RestClient("http://ac50c79e407e44dc89f257057d60ddbf-1643442314.us-east-1.elb.amazonaws.com/api/v1/delivery/estimate/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODUyNTU3NSwiZXhwIjoxNjczODA5NTc1fQ.8WAs-muUnBUrEIv4cevePavSOo_vVLS-jySkDF7tjVOgVo8mTg-NoMzb7OW7JbBBoIL_8L0CJfkkTLFVq5myYg");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""idStore"": 11,
" + "\n" +
@"    ""idBranchStore"": 20,
" + "\n" +
@"    ""description"": ""Sin descripcion"",
" + "\n" +
@"    ""isTest"": true,
" + "\n" +
@"    ""deliveryTime"": ""2022-11-15T15:25:55.999Z"",
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
@"            ""addressStreet"": ""tizo central"",
" + "\n" +
@"            ""personName"": ""Adriana"",
" + "\n" +
@"            ""personEmail"": ""agb@tizo.app"",
" + "\n" +
@"            ""personIdentification"": ""001-030696-0016J"",
" + "\n" +
@"            ""phone"": ""+50557418465"",
" + "\n" +
@"            ""addressHuman"": ""Bodegon mercado oriental"",
" + "\n" +
@"            ""addressGeo"": ""4P8V+8C8, Managua 14031, Nicaragua"",
" + "\n" +
@"            ""instructions"": ""No golpear"",
" + "\n" +
@"            ""latitude"": 12.116088834,
" + "\n" +
@"            ""longitude"": -86.25661897,
" + "\n" +
@"            ""branchName"": ""tizo central"",
" + "\n" +
@"            ""storeName"": ""Tizo bodegon""
" + "\n" +
@"        },
" + "\n" +
@"        {
" + "\n" +
@"            ""type"": ""DROP_OFF"",
" + "\n" +
@"            ""city"": ""Managua"",
" + "\n" +
@"            ""country"": ""Nicaragua"",
" + "\n" +
@"            ""state"": ""Managua"",
" + "\n" +
@"            ""addressStreet"": """",
" + "\n" +
@"            ""personName"": ""Hanzel Urrutia"",
" + "\n" +
@"            ""personEmail"": ""hanzelurrutia8118@gmail.com"",
" + "\n" +
@"            ""personIdentification"": ""888-170702-1002A"",
" + "\n" +
@"            ""phone"": ""+50578849074"",
" + "\n" +
@"            ""addressHuman"": ""Del molino, una cuadra arriba dos y medía al algo"",
" + "\n" +
@"            ""addressGeo"": ""514 P.º las colinas, Managua 14197, Nicaragua"",
" + "\n" +
@"            ""instructions"": ""Decir buenas"",
" + "\n" +
@"            ""latitude"": 12.102190263,
" + "\n" +
@"            ""longitude"": -86.23643979
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""items"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""name"": ""Paquete"",
" + "\n" +
@"            ""fragile"": false,
" + "\n" +
@"            ""document"": false,
" + "\n" +
@"            ""description"": ""m"",
" + "\n" +
@"            ""isUsingCapacities"": false,
" + "\n" +
@"            ""value"": 5,
" + "\n" +
@"            ""weight"": 50,
" + "\n" +
@"            ""height"": 30,
" + "\n" +
@"            ""width"": 40,
" + "\n" +
@"            ""depth"": 30,
" + "\n" +
@"            ""images"": [
" + "\n" +
@"                null
" + "\n" +
@"            ],
" + "\n" +
@"            ""idItemCategory"": 0,
" + "\n" +
@"            ""capacitySelected"": ""Tizo Small0"",
" + "\n" +
@"            ""otherCapacity"": ""m"",
" + "\n" +
@"            ""category"": 0
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""customerEmail"": ""agb@tizo.app""
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);