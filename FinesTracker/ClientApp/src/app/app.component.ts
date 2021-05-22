import { Component } from '@angular/core';
import { MatIconRegistry } from "@angular/material/icon";
import { DomSanitizer } from "@angular/platform-browser";
import {User} from './Models/User';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public user: User;

  constructor() {
    this.user = new User();
    this.user.userId = 1;
    this.user.name = "Jacob";
    this.user.base64Image = "";
  }

}
