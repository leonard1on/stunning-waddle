namespace backend.Configurations;

public class DatabaseOptions
{
  public string DbHost { get; set; } = string.Empty;
  public string DbPort { get; set; } = string.Empty;
  public string DbUsername { get; set; } = string.Empty;
  public string DbPassword { get; set; } = string.Empty;
  public string DbName { get; set; } = string.Empty;
}

public class OpenWeatherOptions
{
  public string ApiKey { get; set; } = string.Empty;
  public string BaseUrl { get; set; } = string.Empty;
  public string WeatherAddress { get; set; } = string.Empty;
  public string GeoAddress { get; set; } = string.Empty;
} 

public class AppConfig
{
  public DatabaseOptions Database { get; set; } = new ();
  public OpenWeatherOptions OpenWeather { get; set; } = new ();
  public string WeatherAppUrl { get; set; } = string.Empty;
  public List<string> AllowedOrigins { get; set; } = new (); 
}