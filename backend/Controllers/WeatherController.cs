using Microsoft.AspNetCore.Mvc;
namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherController : ControllerBase
{
    private readonly IWeatherService _weatherService;

    public WeatherController(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    [HttpGet]
    public async Task<IActionResult> GetWeather([FromQuery] string lat, string lon)
    {
        if (string.IsNullOrWhiteSpace(lat) || string.IsNullOrWhiteSpace(lon))
        {
            return BadRequest("Latitude and longitude parameters are required.");
        }

        var weatherData = await _weatherService.GetWeatherAsync(lat, lon);
        return Ok(weatherData);
    }

    [HttpGet("geo")]
    public async Task<IActionResult> GetGeoData([FromQuery] string cityName)
    {
        if (string.IsNullOrWhiteSpace(cityName))
        {
            return BadRequest("City name parameter is required.");
        }

        var geoData = await _weatherService.GetGeoDataAsync(cityName);
        return Ok(geoData);
    }

    [HttpGet("city")]
    public async Task<IActionResult> GetWeatherByCityName([FromQuery] string cityName)
    {
        if (string.IsNullOrWhiteSpace(cityName))
        {
            return BadRequest("City name parameter is required.");
        }

        var weatherData = await _weatherService.GetWeatherByCityNameAsync(cityName);
        return Ok(weatherData);
    }
}