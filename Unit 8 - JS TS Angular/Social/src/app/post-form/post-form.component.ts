import { Component, EventEmitter, Output } from '@angular/core';
import { Post } from '../post';

@Component({
  selector: 'app-post-form',
  templateUrl: './post-form.component.html',
  styleUrls: ['./post-form.component.css']
})
export class PostFormComponent {
  @Output() submitted = new EventEmitter<Post>();

  display:boolean = false;
  newPost:Post = {} as Post;

  toggleDisplay():void{
    this.display = !this.display;
  }

  createPost():void{
    let result:Post = {
      title: this.newPost.title,
      thought: this.newPost.thought,
      upvotes: 0
    };

    this.submitted.emit(result);
    this.toggleDisplay();
  }
}
