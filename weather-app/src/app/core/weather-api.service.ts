import {inject, Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {Observable} from 'rxjs';
import { AppConfigService } from './app-config/app-config-service';
// import {WeatherData} from '../models/weather-data.model';

@Injectable({
  providedIn: 'root'
})
export class WeatherApiService {
  private readonly http = inject(HttpClient);
  private readonly weatherApiUrl = inject(AppConfigService).apiUrl; // Replace with your actual API URL

  constructor() {}
  // "coord":{"lon":14.4611,"lat":35.8972}
  getWeatherData(lat: number, lon: number): Observable<any> {
    const url = `${this.weatherApiUrl}/weather?lat=${lat}&lon=${lon}`;
    return this.http.get(url);
  }

  getGeoData(city: string, country?: string | undefined, state?: string | undefined): Observable<any> {
    const cityname = `${city}${state && country ? "," + state : ""}${country ? "," + country : ""}`
    const url = `${this.weatherApiUrl}/weather/geo?cityname=${cityname}`;
    return this.http.get(url);
  }

  getWeatherDataCityName(city: string, country?: string | undefined, state?: string | undefined): Observable<any> {
    const cityname = `${city}${state && country ? "," + state : ""}${country ? "," + country : ""}`
    const url = `${this.weatherApiUrl}/weather/city?cityname=${cityname}`;
    return this.http.get(url);
  }
}