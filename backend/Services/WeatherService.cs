using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.Extensions.Options;
using backend.DTOs;
using backend.Configurations;

public class WeatherService : IWeatherService
{
    private readonly HttpClient _httpClient;
    private readonly OpenWeatherOptions _openWeatherConfig;

    public WeatherService(IHttpClientFactory httpClientFactory, IOptions<AppConfig> appConfig)
    {
        _httpClient = httpClientFactory.CreateClient("OpenWeather");
        _openWeatherConfig = appConfig.Value.OpenWeather;
    }

    public async Task<WeatherDataDTO> GetWeatherAsync(string lat, string lon)
    {
        var response = await _httpClient.GetAsync($"{_openWeatherConfig.WeatherAddress}?lat={lat}&lon={lon}&appid={_openWeatherConfig.ApiKey}&units=metric");
        response.EnsureSuccessStatusCode();

        var weatherData = await response.Content.ReadFromJsonAsync<WeatherDataDTO>();
        return weatherData ?? new WeatherDataDTO();
    }

    public async Task<List<GeoDataDTO>> GetGeoDataAsync(string cityName)
    {
        var response = await _httpClient.GetAsync($"{_openWeatherConfig.GeoAddress}?q={cityName}&appid={_openWeatherConfig.ApiKey}");
        response.EnsureSuccessStatusCode();

        var geoData = await response.Content.ReadFromJsonAsync<List<GeoDataDTO>>();
        return geoData ?? new List<GeoDataDTO>();
    }

    public async Task<WeatherDataDTO> GetWeatherByCityNameAsync(string cityName)
    {
        var reesponse = await _httpClient.GetAsync($"{_openWeatherConfig.WeatherAddress}?q={cityName}&appid={_openWeatherConfig.ApiKey}&units=metric");
        reesponse.EnsureSuccessStatusCode();

        var weatherData = await reesponse.Content.ReadFromJsonAsync<WeatherDataDTO>(); 
        return weatherData ?? new WeatherDataDTO();
    }
}