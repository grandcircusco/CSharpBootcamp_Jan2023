import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DonutListModel } from '../Models/donut-list-model';
import { DonutModel } from '../Models/donut-model';

@Injectable({
  providedIn: 'root'
})
export class DonutService {

  url:string = "https://grandcircusco.github.io/demo-apis/donuts";
  constructor(private http:HttpClient) { }

  GetDonuts():Observable<DonutListModel>{
    return this.http.get<DonutListModel>(`${this.url}.json`);
  }

  GetDonutById(id:number):Observable<DonutModel>{
    return this.http.get<DonutModel>(`${this.url}/${id}.json`);
  }
}
