var client = new RestClient("https://staging-api.tizo.co/api/v1/system-data/payment-types/");
client.Timeout = -1;
var request = new RestRequest(Method.GET);
request.AddHeader("Authorization", "eyJhbGciOiJIUzUxMiJ9.eyJyb2xlIjoic3RvcmVfYXBpIiwidXNlcm5hbWUiOiJzdG9yZV8yIiwiaWF0IjoxNjU4MTU0Mjc3LCJleHAiOjE2NTg3NTkwNzd9.u6b7ap-7vYikiIBwJ8ugj7rTM_0nVkuMXVlI-Mz7ayXmPT661F9--p-QfbcOcPtewQliHWqktS5P8YYNgPH3uA");
IRestResponse response = client.Execute(request);
Console.WriteLine(response.Content);