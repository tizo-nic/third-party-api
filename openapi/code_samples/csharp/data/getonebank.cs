var client = new RestClient("{{base_url}}/api/v1/system-data/banks/0/");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "{{auth_token}}");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);