import { Component, Input } from '@angular/core';
import { User } from '../user';

@Component({
  selector: 'app-single-user',
  templateUrl: './single-user.component.html',
  styleUrls: ['./single-user.component.css']
})
export class SingleUserComponent {
 @Input() DisplayUser:User = {} as User; //setup a default object for you
}
