var client = new RestClient("https://staging-api.tizo.co/api/v1/vendors/stores/:idStore/branches/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +@"  ""name"": ""string""," + "\n" +@"  ""idMunicipality"": 0," + "\n" +@"  ""addressGeo"": ""string""," + "\n" +@"  ""addressHuman"": ""string""," + "\n" +@"  ""latitude"": 0," + "\n" +@"  ""longitude"": 0," + "\n" +@"  ""active"": true," + "\n" +@"  ""vacation"": true" + "\n" +@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);