import { Component } from '@angular/core';
import { Department } from './department';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title:string = 'my website';

  age:number = 25;
  //make a boolean
  //isHungry
  //either a true or a false
  //display that on the html
  isHungry:boolean = true;

  names:string[] = ["Justin", "Josh", "Billy"];
  //array of strings
  //favMovies
  //add at least 3 movie titles to it
  //display all movies on the html
  favMovies:string[] = ["Starwars", "Lord of the Rings", "Dr. Strange"];


  // techDepartment:Department = {
  //   name:"Tech Department",
  //   employeeCount: 20,
  //   hiring:false
  // };

  allDepartments:Department[] = [
    {
      name: "Tech Department",
      employeeCount: 20,
      hiring: true
    },
    {
      name: "HR Department",
      employeeCount: 15,
      hiring: false
    },
    {
      name: "Legal Department",
      employeeCount: 3,
      hiring: false
    },
    {
      name: "Sadness Department",
      employeeCount: 3,
      hiring: false
    },
    {
      name:"Catering Department",
      employeeCount:1000,
      hiring:true
    },
    {
      name:"Community Engagement",
      employeeCount:6,
      hiring:false
    },
    {
      name:"Janitorial",
      employeeCount: 1,
      hiring:true
    },
    {
      name: "Quitting Department",
      employeeCount: 1,
      hiring: false
    },
  ];

}
