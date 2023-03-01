import { Component } from '@angular/core';
import { WeatherModel } from '../models/weather-model';
import { WeatherService } from '../services/weather.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.css']
})
export class WeatherComponent {

  result:WeatherModel = {} as WeatherModel;
  constructor(private weatherService:WeatherService){}

  ngOnInit(){

    this.weatherService.getWeather().subscribe((response:WeatherModel) => {
      this.result = response;
      console.log(this.result);
    });

  }


}
