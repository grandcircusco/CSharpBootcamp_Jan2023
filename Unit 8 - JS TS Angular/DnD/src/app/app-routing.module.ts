import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DonutDetailsComponent } from './Components/donut-details/donut-details.component';
import { DonutsComponent } from './Components/donuts/donuts.component';
import { FamousPeopleComponent } from './Components/famous-people/famous-people.component';

const routes: Routes = [
  { path:"Donuts", component: DonutsComponent },
  { path:"Donuts/:id", component:DonutDetailsComponent },
  { path:"Devs", component:FamousPeopleComponent },
  { path:"", redirectTo:"/Donuts", pathMatch:"full" }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
