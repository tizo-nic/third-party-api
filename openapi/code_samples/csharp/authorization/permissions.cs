var client = new RestClient("https://staging-api.tizo.co/api/v1/auth/permissions/");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2dhYnJpZWxfNiIsImlhdCI6MTY1NzY0NzM4NSwiZXhwIjoxNjU4MjUyMTg1fQ.H9utsN8UrmnGR-_xiMe4kr4S0g82f5ejGPwmJowwcdWexxGjlhhAavOLJXylwRKwsAaaTL524eWU8dezi6x8tA");
var body = @"";
request.AddParameter("text/plain", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);