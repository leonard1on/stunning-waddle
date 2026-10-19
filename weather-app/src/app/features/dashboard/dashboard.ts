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

  constructor() {
    this.weatherApi.getWeatherData(35.8972, 14.4611).subscribe((data) => {
      this.weatherData.set(data);
      console.log('weatherData', data);
    });
  }
}
