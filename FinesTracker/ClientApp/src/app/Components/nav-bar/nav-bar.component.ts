import {Component, OnInit, TemplateRef} from '@angular/core';
import {NgbModal} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  constructor(private modalService: NgbModal) { }

  ngOnInit(): void {
  }

  openAddModal(content: TemplateRef<any>) {
    this.modalService.open(content, {ariaLabelledBy: 'Add-New-Fine-Modal'}).result.then
    ((result) => {}, (reason) => {});
  }

  openConfirmModal(content: TemplateRef<any>) {
    this.modalService.open(content, {ariaLabelledBy: 'Confirm-Payment-Fine-Modal', size:'lg'}).result.then
    ((result) => {}, (reason) => {});
  }

}
