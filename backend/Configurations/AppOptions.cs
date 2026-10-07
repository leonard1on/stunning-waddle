namespace backend.Configurations;

public class DatabaseOptions
{
  public string DbHost { get; set; } = string.Empty;
  public string DbPort { get; set; } = string.Empty;
  public string DbUsername { get; set; } = string.Empty;
  public string DbPassword { get; set; } = string.Empty;
  public string DbName { get; set; } = string.Empty;
}

public class AppConfig
{
  public DatabaseOptions Database { get; set; } = new ();
  public string WeatherAppUrl { get; set; } = string.Empty;
  public List<string> AllowedOrigins { get; set; } = new (); 
}