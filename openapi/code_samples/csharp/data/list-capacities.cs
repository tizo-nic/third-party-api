var client = new RestClient("http://staging-api.tizo.co/api/v1/system-data/capacities/");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2FkcmlhbmFfOSIsImlhdCI6MTY4NjU4MzM4MCwiZXhwIjoxNjkxODY3MzgwfQ.8AaS0pzsWQhar3y-c04gXiZUQ18K5voz2n_8G0SFItXgnp21kb9Eg-0a27dCEVAL60f0fU6gLhoJeKouEBufFg");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);