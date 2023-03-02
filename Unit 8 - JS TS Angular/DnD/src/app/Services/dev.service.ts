import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DevModel } from '../Models/dev-list';

@Injectable({
  providedIn: 'root'
})
export class DevService {

  url:string = "https://grandcircusco.github.io/demo-apis/computer-science-hall-of-fame.json";
  constructor(private http:HttpClient) { }

  getDevs():Observable<DevModel>{
    return this.http.get<DevModel>(this.url);
  }
}
