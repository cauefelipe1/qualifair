using Infrastructure.Location;

namespace Infrastructure.OpenAQClient;

public interface IOpenAQClient
{
    public Task<OpenQAApiResult<LocationOpenQADTO>> GetLocations(int page = 1, int limit = 100); 
}