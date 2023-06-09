var client = new RestClient("https://staging-api.tizo.co/api/v1/vendors/stores/0/branches/1/");
client.Timeout = -1;
var request = new RestRequest(Method.PUT);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +@"    ""name"": ""strong""," + "\n" +@"    ""idMunicipality"": 1," + "\n" +@"    ""addressGeo"": ""strong""," + "\n" +@"    ""addressHuman"": ""strong""," + "\n" +@"    ""latitude"": 12.3663," + "\n" +@"    ""longitude"": 14.2222," + "\n" +@"    ""active"": true" + "\n" +@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);