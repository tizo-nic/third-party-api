var client = new RestClient("https://staging-api.tizo.co/api/v1/delivery/send-notification/98871c18-a766-4b06-b528-f39d0b2666ba/");
client.Timeout = -1;
var request = new RestRequest(Method.PUT);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzgwOTQ2MSwiZXhwIjoxNjU4NDE0MjYxfQ.N_rPvlIFgpj_mK8mcWzDbKEgud6bJeSNc5cOKqzyYTvWeCqStlzUCQjeyoNt98GwqpEU-4jdI35jMk83bahzpg");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""whatsapp"": false,
" + "\n" +
@"    ""sms"": false,
" + "\n" +
@"    ""email"": true
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);