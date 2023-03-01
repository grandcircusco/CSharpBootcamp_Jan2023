import { Component, Input } from '@angular/core';
import { Child } from 'src/app/Models/reddit-model';

@Component({
  selector: 'app-reddit-single',
  templateUrl: './reddit-single.component.html',
  styleUrls: ['./reddit-single.component.css']
})
export class RedditSingleComponent {
  @Input() Post:Child = {} as Child;
}
