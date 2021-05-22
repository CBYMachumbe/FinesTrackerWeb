import {Component, Input, OnInit, TemplateRef} from '@angular/core';
import {FinePost} from '../../Models/FinePost';
import {User} from '../../Models/User';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';



@Component({
  selector: 'app-fine',
  templateUrl: './fine.component.html',
  styleUrls: ['./fine.component.css']
})
export class FineComponent implements OnInit {

  @Input() finePost!: FinePost;
  @Input() currentUser!: User;


  constructor(private modalService: NgbModal) {
  }

  ngOnInit(): void {
  }

  public isPostedByCurrentUser(){
    return this.currentUser.userId === this.finePost.finerId;
  }

  openEditFineModal(content: TemplateRef<any>) {
    this.modalService.open(content, {ariaLabelledBy: 'Edit-Fine-Modal'}).result.then
    ((result) => {}, (reason) => {});
  }

  Vote(): void{
    // submit or remove vote on post
    //todo: make fineText 230 characters long
  }
}
