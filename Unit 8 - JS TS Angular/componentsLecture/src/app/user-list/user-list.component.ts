import { Component } from '@angular/core';
import { User } from '../user';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.css']
})
export class UserListComponent {
  Users:User[] = [
    {
      Username:"GrantChirpus",
      Password:"IUsedToBeABird",
      FavDrink:"Water"
    },
    {
      Username:"JustinGC",
      Password:"BajaBlastMaster",
      FavDrink:"Baja Blast"
    },
  ];

  AddUser(newUser:User){
    this.Users.push(newUser);
  }
}
