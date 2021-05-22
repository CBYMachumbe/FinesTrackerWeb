import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-edit-fine',
  templateUrl: './edit-fine.component.html',
  styleUrls: ['./edit-fine.component.css']
})
export class EditFineComponent implements OnInit {

  @Input() modal!: any;

  constructor() { }

  ngOnInit(): void {
  }

}
