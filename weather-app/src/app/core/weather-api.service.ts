import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
// import {WeatherData} from '../models/weather-data.model';

@Injectable({
  providedIn: 'root'
})
export class WeatherApiService {
  private readonly http = inject(HttpClient);
  private readonly weatherApiUrl = 'xxx'; // Replace with your actual API URL

  constructor() {}
  // "coord":{"lon":14.4611,"lat":35.8972}
  getWeatherData(lat: number, lon: number): Observable<any> {
    const url = `${this.weatherApiUrl}/weather?lat=${lat}&lon=${lon}`; // Replace with your actual API key
    return this.http.get(url);
  }
}