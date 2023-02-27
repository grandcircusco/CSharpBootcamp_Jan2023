import { Component } from '@angular/core';
import { ToDo } from '../to-do';

@Component({
  selector: 'app-to-do',
  templateUrl: './to-do.component.html',
  styleUrls: ['./to-do.component.css']
})
export class ToDoComponent {
  tasks:ToDo[] = [
    {
      task:"Drink water",
      completed:true
    },
    {
      task: "Drink Soda",
      completed: true
    }
  ];

  newTask:string = "";
  filter:string = "";

  CompleteTask(index:number):void{
    this.tasks[this.getCorrectIndex(index)].completed = true;
  }

  AddTask():void{
    let result:ToDo = {
      task: this.newTask,
      completed: false
    }

    this.tasks.push(result);
  } 

  IsCompletedList():boolean{
    if(this.tasks.length == 0){
      return true;
    }

    let result:boolean = true;
    this.tasks.forEach((t:ToDo) => {
      if(t.completed == false){
        result = false;
      }
    });

    return result;
  }

  RemoveTask(index:number):void{
    this.tasks.splice(this.getCorrectIndex(index), 1);
  }

  getFiltered():ToDo[]{
    return this.tasks.filter((t:ToDo) => t.task.includes(this.filter));
  }

  getCorrectIndex(index:number):number{
    //index is filtered, we need the original
    let task:ToDo = this.getFiltered()[index];

    return this.tasks.findIndex((t:ToDo) => t.task == task.task && t.completed == task.completed);
  }
}
