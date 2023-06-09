var client = new RestClient("https://staging-api.tizo.co/api/v1/auth/login/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Content-Type", "application/json");
var body = @"{""username"": ""store_0"",""password"": ""12"",""typeUser"": ""store_api""}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);