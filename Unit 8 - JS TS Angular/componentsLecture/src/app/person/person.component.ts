import { Component,  EventEmitter,  Input, Output } from '@angular/core';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent {
  //parent to child
  @Input() name:string = "Justin";

  //child to parent
  @Output() selectedName = new EventEmitter<string>();

  chooseName():void{
    this.selectedName.emit(this.name);
  }
}
