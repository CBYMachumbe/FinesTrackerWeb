import {Component, Input, OnInit} from '@angular/core';

@Component({
  selector: 'app-confirm-payment',
  templateUrl: './confirm-payment.component.html',
  styleUrls: ['./confirm-payment.component.css']
})
export class ConfirmPaymentComponent implements OnInit {
  @Input() modal: any;

  displayedColumns: string[] = ['User', 'Payment Description','Date','Votes'];
  data = [{user: {name: 'Jacob'}, paymentDescription: 'Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo ligula eget dolor. Aenean m', date: '20 July 2021', votes:[{},{},{}], voted:true}];
  constructor() { }

  ngOnInit(): void {
  }

}
