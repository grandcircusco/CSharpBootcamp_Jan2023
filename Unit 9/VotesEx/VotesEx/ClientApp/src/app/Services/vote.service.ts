import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Vote } from '../Models/vote';

@Injectable({
  providedIn: 'root'
})
export class VoteService {

  constructor(@Inject('BASE_URL') private baseUrl: string, private http:HttpClient) { }

  getAllVotes():Observable<Vote[]>{
    return this.http.get<Vote[]>(`${this.baseUrl}api/Vote/getVotes`);
  }

  castVote(id:number):Observable<Vote>{
    return this.http.put<Vote>(`${this.baseUrl}api/Vote/addVote?Id=${id}`, {});
  } 
}
