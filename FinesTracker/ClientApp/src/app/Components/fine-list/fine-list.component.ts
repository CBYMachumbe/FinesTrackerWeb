import { Component, OnInit, ViewChild } from '@angular/core';
import {FineService} from '../../Services/Fine.service';
import { Observable, BehaviorSubject } from 'rxjs';
import { map, tap, scan, mergeMap, throttleTime } from 'rxjs/operators';
import {Fine} from '../../Models/Fine';
import {FinePost} from '../../Models/FinePost';
import {FinePostService} from '../../Services/FinePost.service';
import {CdkVirtualScrollViewport} from '@angular/cdk/scrolling';

const pageSize = 20;

@Component({
  selector: 'app-fine-list',
  templateUrl: './fine-list.component.html',
  styleUrls: ['./fine-list.component.css']
})
export class FineListComponent implements OnInit {

  private isEndOfList = false;
  private offset = new BehaviorSubject(null);

  @ViewChild(CdkVirtualScrollViewport)
  public viewport!: CdkVirtualScrollViewport;
  public finePost$!: Array<FinePost>;

  constructor(private service: FinePostService) { }

  ngOnInit(): void {
    this.service.getAllFinePosts(1, 10).subscribe(
      next => this.finePost$ = next
    );
  }

}
