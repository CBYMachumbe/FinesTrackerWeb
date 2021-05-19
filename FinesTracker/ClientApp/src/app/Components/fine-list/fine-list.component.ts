import { Component, OnInit, ViewChild } from '@angular/core';
import {Observable, BehaviorSubject, Subscription} from 'rxjs';
import {FinePost} from '../../Models/FinePost';
import {FinePostService} from '../../Services/FinePost.service';
import {CdkVirtualScrollViewport} from '@angular/cdk/scrolling';
import {Fine} from '../../Models/Fine';
import {CollectionViewer, DataSource} from '@angular/cdk/collections';

@Component({
  selector: 'app-fine-list',
  templateUrl: './fine-list.component.html',
  styleUrls: ['./fine-list.component.css']
})
export class FineListComponent implements OnInit {
  private pageLength = 10;
  private page: number;
  private isEndOfList = false;
  private offset = new BehaviorSubject(null);

  @ViewChild(CdkVirtualScrollViewport)
  public viewport!: CdkVirtualScrollViewport;
  public finePost$!: Array<FinePost>;

  constructor(private service: FinePostService) {
    this.page = 1;
  }

  ngOnInit(): void {
    this.service.getAllFinePosts(this.page, this.pageLength).subscribe(
      next => {
        console.log(next);
        this.finePost$ = next;
      }
    );
  }

  getFinePosts(): void {
    this.page++;
    this.service.getAllFinePosts(this.page, this.pageLength).subscribe(
      next => {
        if(next === []){
          this.isEndOfList = true;
        }
        this.finePost$.push(...next);
      }
    );

  }

}


