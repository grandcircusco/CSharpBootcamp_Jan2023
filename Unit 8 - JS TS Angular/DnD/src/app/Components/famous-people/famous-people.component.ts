import { Component } from '@angular/core';
import { DevModel } from 'src/app/Models/dev-list';
import { DevService } from 'src/app/Services/dev.service';

@Component({
  selector: 'app-famous-people',
  templateUrl: './famous-people.component.html',
  styleUrls: ['./famous-people.component.css']
})
export class FamousPeopleComponent {
  result:DevModel = {} as DevModel;

  constructor(private devService:DevService){}

  ngOnInit(){
    this.devService.getDevs().subscribe((response:DevModel) => {
      console.log(response);
      this.result = response;
    });
  }
}
