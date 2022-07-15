var client = new RestClient("https://api.tizo.co/api/v1/delivery/confirm/6ce15dac-83d2-4631-a32d-12b753da8fbc");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg");
request.AddHeader("Content-Type", "application/json");
var body = @"{}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);