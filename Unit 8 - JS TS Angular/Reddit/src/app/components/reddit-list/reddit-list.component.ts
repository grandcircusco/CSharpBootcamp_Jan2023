import { Component } from '@angular/core';
import { RedditModel } from 'src/app/Models/reddit-model';
import { RedditService } from 'src/app/services/reddit.service';

@Component({
  selector: 'app-reddit-list',
  templateUrl: './reddit-list.component.html',
  styleUrls: ['./reddit-list.component.css']
})
export class RedditListComponent {
  constructor(private redditService:RedditService){}

  result:RedditModel = {} as RedditModel;
  search:string = "aww";
  status:string = "";

  ngOnInit(){
    this.searchSubreddit();
  }

  searchSubreddit(){
    this.redditService.getReddit(this.search).subscribe((response:RedditModel) => {
      this.result = response;
      this.result.data.children.splice(10);
      this.status = "";
    },
    (error) => {
      console.log(error)
      this.status = `${this.search} not a subreddit`;
    }
    );
  }

}
