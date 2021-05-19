import { Component, OnInit } from '@angular/core';
import {FinePostService} from '../../Services/FinePost.service';
import {Observable} from 'rxjs';
import {TallyObject} from '../../Models/TallyObject';

@Component({
  selector: 'app-fine-tally',
  templateUrl: './fine-tally.component.html',
  styleUrls: ['./fine-tally.component.css']
})
export class FineTallyComponent implements OnInit {
  displayedColumns: string[] = ['User', 'Total Fines', 'Fines Due'];
  tallie$!: Observable<Array<TallyObject>>;

  constructor(private service: FinePostService) { }

  ngOnInit(): void {
    this.tallie$ = this.service.getTallyObjects();
  }

}

