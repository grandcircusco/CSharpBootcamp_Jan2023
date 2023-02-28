import { Component } from '@angular/core';
import { PeopleService } from '../people.service';
import { Person } from '../person';

@Component({
  selector: 'app-people',
  templateUrl: './people.component.html',
  styleUrls: ['./people.component.css']
})
export class PeopleComponent {
  constructor(private peopleService:PeopleService){

  }

  AllPeople:Person[] = [];

  ngOnInit(){
    this.AllPeople = this.peopleService.getAll();
  }

}
