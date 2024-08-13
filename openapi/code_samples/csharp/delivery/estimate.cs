var client = new RestClient("http://staging-api.tizo.co/api/v1/delivery/estimate/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""type"": ""string"",
" + "\n" +
@"    ""waypoints"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""type"": ""string"",
" + "\n" +
@"            ""city"": ""string"",
" + "\n" +
@"            ""country"": ""string"",
" + "\n" +
@"            ""state"": ""string"",
" + "\n" +
@"            ""addressStreet"": ""string"",
" + "\n" +
@"            ""personName"": ""string"",
" + "\n" +
@"            ""personIdentification"": ""string"",
" + "\n" +
@"            ""phone"": ""string"",
" + "\n" +
@"            ""addressHuman"": ""string"",
" + "\n" +
@"            ""addressGeo"": ""string"",
" + "\n" +
@"            ""personEmail"": ""string"",
" + "\n" +
@"            ""instructions"": ""string"",
" + "\n" +
@"            ""latitude"": 0,
" + "\n" +
@"            ""longitude"": 0
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""items"": [
" + "\n" +
@"        {
" + "\n" +
@"            ""weight"": 0,
" + "\n" +
@"            ""height"": 0,
" + "\n" +
@"            ""width"": 0,
" + "\n" +
@"            ""depth"": 0,
" + "\n" +
@"            ""idItemCategory"": 0,
" + "\n" +
@"            ""idCapacity"": 0,
" + "\n" +
@"            ""value"": 0,
" + "\n" +
@"            ""fragile"": true
" + "\n" +
@"        }
" + "\n" +
@"    ],
" + "\n" +
@"    ""deliveryTime"": ""string"",
" + "\n" +
@"    ""isTest"": true,
" + "\n" +
@"    ""idStore"": 0,
" + "\n" +
@"    ""collectMoney"": 0,
" + "\n" +
@"    ""lineBusiness"": ""string""
" + "\n" +
@"}";

request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);