var client = new RestClient("https://staging-api.tizo.co/api/v1/vendors/stores/1/notifications/");
client.Timeout = -1;
var request = new RestRequest(Method.PUT);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw");
request.AddHeader("Content-Type", "application/json");
var body = @"{" + "\n" +@"    ""sendEmail"": 1," + "\n" +@"    ""sendSms"": 1," + "\n" +@"    ""sendWhatsapp"": 1," + "\n" +@"    ""sendPush"": 1," + "\n" +@"    ""sendTelegram"": 1" + "\n" +@"}";
request.AddParameter("application/json", body,  ParameterType.RequestBody);
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);