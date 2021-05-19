import {Component, Input, OnInit} from '@angular/core';
import {MatIconRegistry} from '@angular/material/icon';
import {DomSanitizer} from '@angular/platform-browser';
import {FinePost} from '../../Models/FinePost';



@Component({
  selector: 'app-fine',
  templateUrl: './fine.component.html',
  styleUrls: ['./fine.component.css']
})
export class FineComponent implements OnInit {

  @Input() finePost!: FinePost;

  constructor(private mIC: MatIconRegistry, private domSanitizer: DomSanitizer) {
    this.mIC.addSvgIcon(
      "vote",
      this.domSanitizer.bypassSecurityTrustResourceUrl("../assets/Images/ballot.svg")
    );
  }

  ngOnInit(): void {
  }

}
