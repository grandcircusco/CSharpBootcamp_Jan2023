import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DonutModel } from 'src/app/Models/donut-model';
import { DonutService } from 'src/app/Services/donut.service';

@Component({
  selector: 'app-donut-details',
  templateUrl: './donut-details.component.html',
  styleUrls: ['./donut-details.component.css']
})
export class DonutDetailsComponent {

  result:DonutModel = {} as DonutModel;
  constructor(private donutService:DonutService, private route:ActivatedRoute){}

  ngOnInit(){
    let paramMap = this.route.snapshot.paramMap;
    let id:number = Number(paramMap.get("id"));
    // console.log(id);
    this.donutService.GetDonutById(id).subscribe((response:DonutModel) => {
      console.log(response);
      this.result = response;
    });
  }
}
