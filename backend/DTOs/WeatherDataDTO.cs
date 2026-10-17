using System.Text.Json.Serialization;

namespace backend.DTOs;

public class WeatherDataDTO
{
    [JsonPropertyName("coord")]
    public CoordinatesDTO Coordinates { get; set; } = new();

    [JsonPropertyName("weather")]
    public List<WeatherConditionDTO> Weather { get; set; } = [];

    [JsonPropertyName("base")]
    public string Base { get; set; } = string.Empty;

    [JsonPropertyName("main")]
    public MainWeatherDTO Main { get; set; } = new();

    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }

    [JsonPropertyName("wind")]
    public WindDTO Wind { get; set; } = new();

    [JsonPropertyName("rain")]
    public RainDTO? Rain { get; set; }

    [JsonPropertyName("clouds")]
    public CloudsDTO Clouds { get; set; } = new();

    [JsonPropertyName("dt")]
    public long DateTime { get; set; }

    [JsonPropertyName("sys")]
    public SystemInfoDTO System { get; set; } = new();

    [JsonPropertyName("timezone")]
    public int Timezone { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("cod")]
    public int Code { get; set; }
}

public class CoordinatesDTO
{
    [JsonPropertyName("lon")]
    public double Longitude { get; set; }

    [JsonPropertyName("lat")]
    public double Latitude { get; set; }
}

public class WeatherConditionDTO
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("main")]
    public string Main { get; set; } = string.Empty;

    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = string.Empty;
}

public class MainWeatherDTO
{
    [JsonPropertyName("temp")]
    public double Temperature { get; set; }

    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("temp_min")]
    public double MinimumTemperature { get; set; }

    [JsonPropertyName("temp_max")]
    public double MaximumTemperature { get; set; }

    [JsonPropertyName("pressure")]
    public int Pressure { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("sea_level")]
    public int SeaLevel { get; set; }

    [JsonPropertyName("grnd_level")]
    public int GroundLevel { get; set; }
}

public class WindDTO
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }

    [JsonPropertyName("deg")]
    public int Degrees { get; set; }

    [JsonPropertyName("gust")]
    public double? Gust { get; set; }
}

public class RainDTO
{
    [JsonPropertyName("1h")]
    public double OneHour { get; set; }
}

public class CloudsDTO
{
    [JsonPropertyName("all")]
    public int Coverage { get; set; }
}

public class SystemInfoDTO
{
    [JsonPropertyName("type")]
    public int? Type { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; } = string.Empty;

    [JsonPropertyName("sunrise")]
    public long Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public long Sunset { get; set; }
}