using backend.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<AppConfig>(builder.Configuration.GetSection("AppConfig"));

builder.Services.AddHttpClient("OpenWeather", client =>
{
  client.BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/");
});

var appConfig = new AppConfig();

var origins = appConfig.AllowedOrigins.Count > 0 
  ? appConfig.AllowedOrigins.ToArray() 
  : ["http://localhost:4200"];

builder.Services.AddCors(options =>
{
  options.AddPolicy("AllowAngularApp",
    policy =>
    {
      policy.WithOrigins(appConfig.AllowedOrigins.ToArray())
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseCors("AllowAngularApp");

app.UseAuthorization();

app.MapControllers();

app.Run();
