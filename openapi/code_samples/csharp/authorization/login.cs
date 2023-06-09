var client = new RestClient("https://staging-api.tizo.co/api/v1/auth/login/");
client.Timeout = -1;
var request = new RestRequest(Method.POST);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODE3OTE2MywiZXhwIjoxNjY4NzgzOTYzfQ.NFIxkVowStlEtnDa2RXTKLGQWv844q5EPI3oBSkjGRlVz-jTd4IXSfl8byOpzZurm6ScyslhgJ_kjuJZTgFQFQ");
request.AddHeader("Content-Type", "application/json");
var body = @"{
" + "\n" +
@"    ""username"": ""store_11"",
" + "\n" +
@"    ""password"": ""12"",
" + "\n" +
@"    ""typeUser"": ""store_api""
" + "\n" +
@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);