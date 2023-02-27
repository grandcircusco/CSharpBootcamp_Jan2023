import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'componentsLecture';

  Name:string = "";

  changeName(value:string){
    this.Name = value;
  }
}
