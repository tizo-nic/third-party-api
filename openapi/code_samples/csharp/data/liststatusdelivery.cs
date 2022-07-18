var client = new RestClient("https://api.tizo.co/api/v1/system-data/status-deliveries/");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoidmVuZG9yIiwidXNlcm5hbWUiOiJ2X2F4ZWxfOSIsImlhdCI6MTY1ODE2NDM4OCwiZXhwIjoxNjU4NzY5MTg4fQ.vvLtYB4O73futNvwzTZt2LhFzNV--XvMfTT5-62YWtxX-9CY6X4-UtIVDkCR_MX4YqX83AcCXiquHAb8uNHIjw");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);