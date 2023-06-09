var client = new RestClient("https://staging-api.tizo.co/api/v1/delivery/get/?idDelivery=304");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8xMSIsImlhdCI6MTY2ODE4MDY3MywiZXhwIjoxNjY4Nzg1NDczfQ.Epg1NeTr_R2de8jUQW-B2eJxyEFpC00CaJMmxsHHFbP9tkHBWhU7eTLIe47GHWchyy_-z-WthaloG92yFeblHg");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);