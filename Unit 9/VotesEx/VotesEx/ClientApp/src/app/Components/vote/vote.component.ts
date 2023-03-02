import { Component, OnInit } from '@angular/core';
import { Vote } from 'src/app/Models/vote';
import { VoteService } from 'src/app/Services/vote.service';

@Component({
  selector: 'app-vote',
  templateUrl: './vote.component.html',
  styleUrls: ['./vote.component.css']
})
export class VoteComponent implements OnInit {

  votes:Vote[] = [];
  constructor(private voteService:VoteService) { }

  ngOnInit(): void {
    this.voteService.getAllVotes().subscribe((response:Vote[]) => {
      this.votes = response;
    }); 
  }

  AddVote(id:number){
    this.voteService.castVote(id).subscribe((response:Vote) => {
      console.log(response);
      let index = this.votes.findIndex((v) => v.id == id);
      this.votes[index].votes = response.votes;
    });
  }

}
