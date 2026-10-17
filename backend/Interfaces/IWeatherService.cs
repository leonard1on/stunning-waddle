using System.Threading.Tasks;
using backend.DTOs;
public interface IWeatherService
{
    Task<WeatherDataDTO> GetWeatherAsync(string lat, string lon);
    Task<List<GeoDataDTO>> GetGeoDataAsync(string cityName);
    Task<WeatherDataDTO> GetWeatherByCityNameAsync(string cityName);
}