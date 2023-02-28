import { Component } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-social-posts',
  templateUrl: './social-posts.component.html',
  styleUrls: ['./social-posts.component.css']
})
export class SocialPostsComponent {
  posts:Post[] = [
    {
      title: "Angular",
      thought: "This is a lot of work but very cool.",
      upvotes: 0
    },
    {
      title: "Hungry",
      thought: "Wish I had some Taco Bell rn.",
      upvotes: 0
    },
  ];

  AddPost(newPost:Post):void{
    this.posts.unshift(newPost);
  }

  OnDelete(p:Post):void{
    let index:number = this.posts.findIndex(post => post == p);
    this.posts.splice(index,1);
  }
}
