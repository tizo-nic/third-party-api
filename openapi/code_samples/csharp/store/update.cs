var client = new RestClient("https://api.tizo.co/api/v1/vendors/stores/0/");
client.Timeout = -1;
var request = new RestRequest(Method.PUT);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODMyNzMzMywiZXhwIjoxNjU4OTMyMTMzfQ.JB8oNrBgDqQyymETvZBarNQjs6vRx-zdwVnGvjlqLdB7GgtI8B-yj7haPdqG0OSrFltgMp2HN5msNR268qJlxw");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +@"    ""active"": true" + "\n" +@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);