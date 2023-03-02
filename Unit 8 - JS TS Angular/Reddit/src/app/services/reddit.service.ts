import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { RedditModel } from '../Models/reddit-model';

@Injectable({
  providedIn: 'root'
})
export class RedditService {
  //cows/.json
  url: string = "https://www.reddit.com/r";
  constructor(private http:HttpClient) { }

  getReddit(subreddit:string):Observable<RedditModel>{
    return this.http.get<RedditModel>(`${this.url}/${subreddit}/.json`);
  }

}
