import { Component } from '@angular/core';
import { BlogModel } from '../models/blog-model';
import { BlogService } from '../services/blog.service';

@Component({
  selector: 'app-blog',
  templateUrl: './blog.component.html',
  styleUrls: ['./blog.component.css']
})
export class BlogComponent {
  constructor(private blogService:BlogService){}
  
  result:BlogModel = {} as BlogModel;

  ngOnInit(){
    this.blogService.getPosts().subscribe((response:BlogModel) => {
      console.log(response);
      this.result = response;
    });
  }
}
