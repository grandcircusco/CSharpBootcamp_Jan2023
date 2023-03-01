import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { WeatherModel } from '../models/weather-model';

@Injectable({
  providedIn: 'root'
})
export class WeatherService {
  apiUrl = "https://forecast.weather.gov/MapClick.php?lat=42.335993&lon=-83.049806&FcstType=json";

  constructor(private http: HttpClient) { }

  getWeather():Observable<WeatherModel>{
    return this.http.get<WeatherModel>(this.apiUrl);
  }

}
