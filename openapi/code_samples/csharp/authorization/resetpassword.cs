var client = new RestClient("https://staging-api.tizo.co/api/v1/auth/reset-password/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8yIiwiaWF0IjoxNjY4MTc3Mjc2LCJleHAiOjE2Njg3ODIwNzZ9.OKgtyp6DYHkANu-s-BZaHj1jAs0d6Pq37_3hiPm1C2EQ6XxHwpzN36FZsG5o0L29lno7Qryt3gFn4GfzVdETyA");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""password"": ""12"",
" + "\n" +
@"    ""oldPassword"": ""12""
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);