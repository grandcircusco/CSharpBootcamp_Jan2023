import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PeopleService } from '../people.service';
import { Person } from '../person';

@Component({
  selector: 'app-people-detail',
  templateUrl: './people-detail.component.html',
  styleUrls: ['./people-detail.component.css']
})
export class PeopleDetailComponent {

  //dependency injection
  constructor(private route:ActivatedRoute, private peopleService:PeopleService){}

  // runs when component first loads
  ngOnInit(){
    const routeParams = this.route.snapshot.paramMap;
    let id:number = Number(routeParams.get("id"));
    console.log(id);

    this.DisplayPerson = this.peopleService.getByIndex(id);
  }

  DisplayPerson:Person = {} as Person;
}
