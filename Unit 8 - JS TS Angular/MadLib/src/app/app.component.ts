import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  //two way binding
  title = 'MadLib';
  //mad libs
  Noun:string = "";
  Noun2:string = "";
  Adjective:string = "";
  Food:string = "";
  Place:string = "";


  //form posting example
  names:string[] = [ "Justin", "Josh"];
  newName:string = "";
  addName():void{
    this.names.push(this.newName);
  }

  //forms with interfaces
  products:product[] = [
    {
      name: "Hammer",
      price: 5.99
    },
    {
      name: "Screwdriver",
      price: 3.99
    }
  ];

  newProduct:product = {
    name:"",
    price:0
  };

  addProduct(){
    let result:product = {
      name: this.newProduct.name,
      price: this.newProduct.price
    };
    this.products.push(result);
  }

  removeProduct(index:number){
    this.products.splice(index, 1);
  }
}


interface product {
  name:string;
  price:number;
}