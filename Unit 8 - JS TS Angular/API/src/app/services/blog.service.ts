import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { BlogModel } from '../models/blog-model';

@Injectable({
  providedIn: 'root'
})
export class BlogService {
  url: string = "https://grandcircusco.github.io/demo-apis/blog-posts.json";
  constructor(private http:HttpClient) { }

  getPosts():Observable<BlogModel>{
    return this.http.get<BlogModel>(this.url);
  }
}
