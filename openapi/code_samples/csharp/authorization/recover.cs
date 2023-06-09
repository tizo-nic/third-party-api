var client = new RestClient("https://staging-api.tizo.co/api/v1/auth/recovery-password/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"  ""method"": ""email"",
" + "\n" +
@"  ""wordToMatch"": ""m_yoni3"",
" + "\n" +
@"  ""typeUser"": ""manager""
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);