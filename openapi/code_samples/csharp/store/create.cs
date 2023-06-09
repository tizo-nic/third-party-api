var client = new RestClient("https://staging-api.tizo.co/api/v1/vendors/stores/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +@"    ""name"": ""TADA""," + "\n" +@"    ""ruc"": ""12121""," + "\n" +@"    ""email"": ""agarciadarce@gmail.com""," + "\n" +@"    ""dba"": ""AA""," + "\n" +@"    ""isPrivate"": true," +"\n" +@"    ""pathImage"": """"," + "\n" +@"    ""phone"": ""+50587878787""," + "\n" +@"    ""description"": ""AA""," + "\n" +@"    ""vacation"": false" + "\n" +@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);