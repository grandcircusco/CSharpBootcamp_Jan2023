import { Component, EventEmitter, Output } from '@angular/core';
import { User } from '../user';

@Component({
  selector: 'app-registration',
  templateUrl: './registration.component.html',
  styleUrls: ['./registration.component.css']
})
export class RegistrationComponent {
  newUser:User = {} as User;
  @Output() UserCreated = new EventEmitter<User>();

  CreateUser():void{
    //have to do this to avoid variable ref problem
    let result:User = {
      Username: this.newUser.Username,
      Password: this.newUser.Password,
      FavDrink: this.newUser.FavDrink
    };

    this.UserCreated.emit(result);
  }
}
