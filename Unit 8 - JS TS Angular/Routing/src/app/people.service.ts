import { Injectable } from '@angular/core';
import { Person } from './person';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  constructor() { }

  getAll():Person[]{
    return this.people;
  }

  getByIndex(index:number):Person{
    return this.people[index];
  }

  people:Person[] = [
    {
      FirstName:"Justin",
      LastName:"Jones",
      Age:25,
      Caffeinated:false
    },
    {
      FirstName:"Jun",
      LastName:"Kim",
      Age:24,
      Caffeinated:false
    },
    {
      FirstName: "Josh",
      LastName: "Strathres",
      Age: 41,
      Caffeinated: false
    },
    {
      FirstName:"Michael",
      LastName:"Blackburn",
      Age:28,
      Caffeinated:false
    },
    {
      FirstName:"Belle",
      LastName:"Baxley",
      Age:31,
      Caffeinated:false
    },
    {
      FirstName:"Mourad",
      LastName:"Alfadil",
      Age:26,
      Caffeinated:true
    },
    {
      FirstName:"Ethan",
      LastName: "Thomas",
      Age: 28,
      Caffeinated:true
    },
    {
      FirstName:"Chris",
      LastName:"Washington",
      Age:23,
      Caffeinated:false
    },
    {
      FirstName: "John",
      LastName: "Glandon",
      Age: 38,
      Caffeinated: true
    },
    {
      FirstName:"Allison",
      LastName: "Jones",
      Age: 33,
      Caffeinated: true
    },
    {
      FirstName: "Wilfredo",
      LastName: "Pacheco",
      Age: 25,
      Caffeinated: false
    },
    {
      FirstName:"Carissa",
      LastName:"Cammarata",
      Age:29,
      Caffeinated:false
    },
  ];
}
