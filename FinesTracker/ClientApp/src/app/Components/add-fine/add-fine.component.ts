import {Component, Input, OnInit} from '@angular/core';
import {User} from '../../Models/User';
import {UserService} from '../../Services/User.service';
import {FinePost} from '../../Models/FinePost';
import {FinePostService} from '../../Services/FinePost.service';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import {Fine} from '../../Models/Fine';

@Component({
  selector: 'app-add-fine',
  templateUrl: './add-fine.component.html',
  styleUrls: ['./add-fine.component.css']
})
export class AddFineComponent implements OnInit{

  @Input() modal: any;

  public users!: Array<User>;
  public fine!: Fine;

  public fineTitleFormControl!: FormControl;
  public fineTextFormControl!: FormControl;
  public fineeIdFormControl!: FormControl;

  public finePostFormGroup!: FormGroup;

  public fineeId!: number;

  constructor(private userService: UserService, private finePostService: FinePostService,
              private formBuilder: FormBuilder) {

  }

  ngOnInit(): void {
    this.getUsers();
    this.setUpForm()

    this.fine = new Fine(0, '','');
    this.finePostFormGroup.patchValue(this.fine);
  }

  sendFine(): void {
    const post = new FinePost();
    post.fine = new Fine(0, this.fineTitleFormControl.value, this.fineTextFormControl.value);
    post.votes = [];
    post.fineeId = this.fineeIdFormControl.value;
    post.finerId = 1; /*current user that's logged in*/

    this.finePostService.addNewFinePost(post).subscribe();
  }

  getUsers(): void {
    this.userService.getUsers(1,10).subscribe(
      next => this.users = next
    );
  }

  setUpForm(): void {
    this.fineTitleFormControl = new FormControl('',
      [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(50)
      ]);

    this.fineTextFormControl = new FormControl('',
      [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(255)
      ]);

    this.fineeIdFormControl = new FormControl(-1,[
      Validators.required,
      Validators.min(0)

    ]);

    this.finePostFormGroup = this.formBuilder.group({
      fineTitle: this.fineTitleFormControl,
      fineText: this.fineTextFormControl
    });
  }

}
