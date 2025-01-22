using System.Text.Json;
using System.Text.Json.Serialization;
using Infrastructure.Location;

namespace Infrastructure.OpenAQClient;

public class OpenAQClientRest : IOpenAQClient
{
    const string BASEP_URL = "https://api.openaq.org/v3";
    private HttpClient _httpClient;
    
    public OpenAQClientRest(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<OpenQAApiResult<LocationOpenQADTO>> GetLocations(int page = 1, int limit = 100)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"{BASEP_URL}/locations?page={page}&limit={limit}&order_by=id&sort_order=asc");
        
        request.Headers.Add("X-API-Key", "f403bf7a4f75dd17316d459d80821a246a1759c2ac28f4ef3f054a79824bbaf2");
        var response = await _httpClient.SendAsync(request);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<OpenQAApiResult<LocationOpenQADTO>>(content, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        });

        return result;
        
    }
}