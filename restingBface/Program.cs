using RestSharp;
using System.Text.Json;

RestClient client = new RestClient("https://digi-api.com/api/v1/digimon/");
RestRequest request = new RestRequest("Bakemon");
RestResponse response = client.GetAsync(request).Result;
Digimon p = JsonSerializer.Deserialize<Digimon>(response.Content);

Console.WriteLine(p.name);
Console.ReadLine();
