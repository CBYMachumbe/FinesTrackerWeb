import {AfterViewInit, ChangeDetectorRef, Component, Input, NgZone, OnInit, ViewChild} from '@angular/core';
import {FinePost} from '../../Models/FinePost';
import {FinePostService} from '../../Services/FinePost.service';
import {CdkVirtualScrollViewport, ScrollDispatcher} from '@angular/cdk/scrolling';
import { filter } from 'rxjs/operators';
import {User} from '../../Models/User';

@Component({
  selector: 'app-fine-list',
  templateUrl: './fine-list.component.html',
  styleUrls: ['./fine-list.component.css']
})
export class FineListComponent implements OnInit, AfterViewInit {

  @Input()
  public currentUser!: User;


  private pageLength = 10;
  private page: number;
  public isEndOfList = false;
  public isLoading = true;

  @ViewChild(CdkVirtualScrollViewport)
  public viewport!: CdkVirtualScrollViewport;
  public finePost$: Array<FinePost | null>;

  constructor(private service: FinePostService, private scrollDispatcher: ScrollDispatcher, private cd: ChangeDetectorRef, private zone:NgZone) {
    this.page = 0;
    this.finePost$ = [];
  }

  ngOnInit(): void {
    this.getFinePosts();
  }

  ngAfterViewInit(): void {
    this.scrollDispatcher.scrolled().pipe(
      filter(event => this.viewport.getRenderedRange().end === this.viewport.getDataLength())).subscribe(event => {
          this.getFinePosts();
          this.cd.detectChanges();
    });
  }

  getFinePosts(): void {
    this.isLoading = true;
    if(!this.isEndOfList){
      this.page++;
      this.service.getAllFinePosts(this.page, this.pageLength).subscribe(
        next => {
          if(next.length === 0){
            this.isEndOfList = true;
          }
          else {
            this.finePost$ = this.finePost$.concat(next);
          }
        });
    }
    this.isLoading = false;
  }
}


