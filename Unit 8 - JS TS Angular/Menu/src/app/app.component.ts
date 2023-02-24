import { Component } from '@angular/core';
import { MenuItem } from './menu-item';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  Menu:MenuItem[] = [
    {
      Name: "Chicken Fingers",
      Category: "Dinner",
      Price: 11.99
    },
    {
      Name: "Cinnamon Roll",
      Category: "Dessert",
      Price: 8.99
    },
    {
      Name: "Ceasar Salad",
      Category: "Salads",
      Price: 5.99
    },
    {
      Name: "Breadsticks",
      Category: "Sides",
      Price: 4.99
    },
    {
      Name: "Wings",
      Category: "Sides",
      Price: 8.99
    },
    {
      Name: "Pizza",
      Category: "Dinner",
      Price: 11.99
    }
  ];

  // getByCategory(Cat:string):MenuItem[]{
  //   let result:MenuItem[] = [];

  //   this.Menu.forEach((m:MenuItem) => {
  //     if(m.Category.toLowerCase().trim() == Cat.toLowerCase().trim()){
  //       result.push(m);
  //     }
  //   });

  //   return result;
  // }

  getByCategory(Cat:string):MenuItem[]{
    return this.Menu.filter((m:MenuItem) => m.Category.toLowerCase().trim() == Cat.toLowerCase().trim());
  }
}
