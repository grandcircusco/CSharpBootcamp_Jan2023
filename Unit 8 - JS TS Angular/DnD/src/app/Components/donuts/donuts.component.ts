import { Component } from '@angular/core';
import { DonutListModel } from 'src/app/Models/donut-list-model';
import { DonutService } from 'src/app/Services/donut.service';

@Component({
  selector: 'app-donuts',
  templateUrl: './donuts.component.html',
  styleUrls: ['./donuts.component.css']
})
export class DonutsComponent {

  Result:DonutListModel = {} as DonutListModel;

  constructor(private donutsService:DonutService){}

  ngOnInit(){
    this.donutsService.GetDonuts().subscribe((response:DonutListModel) => {
      console.log(response);
      this.Result = response;
    });
  }
}
