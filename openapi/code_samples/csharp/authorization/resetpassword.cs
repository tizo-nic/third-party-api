var client = new RestClient("https://api.tizo.co/api/v1/auth/reset-password/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" + @"    ""password"": ""12"", " + "\n" + @"    ""oldPassword"": ""a""
" + "\n" + @"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);