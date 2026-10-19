import { Component, inject, signal } from '@angular/core';
import { WeatherApiService } from '../../core/weather-api.service';

@Component({
  imports: [],
  selector: 'app-dashboard',
  styleUrl: './dashboard.css',
  templateUrl: './dashboard.html',
})
export class Dashboard {
  weatherApi = inject(WeatherApiService);
  weatherData = signal<any | null>(null);
  weatherData2 = signal<any | null>(null);
  geoData = signal<any | null>(null);

  constructor() {
    this.weatherApi.getWeatherData(35.8972, 14.4611).subscribe((data) => {
      this.weatherData.set(data);
      console.log('weatherData', data);
    });

    this.weatherApi.getWeatherDataCityName("Birkirkara").subscribe((data) => {
      this.weatherData2.set(data);
      console.log('weatherData2', data);
    });

    this.weatherApi.getGeoData("Tegucigalpa").subscribe((data) => {
      this.geoData.set(data);
      console.log('geoData', data);
    });
  }
}
