import {Component, Input, OnInit} from '@angular/core';
import {FormBuilder, FormControl, FormGroup, Validators} from '@angular/forms';
import {FinePost} from '../../Models/FinePost';

@Component({
  selector: 'app-edit-fine',
  templateUrl: './edit-fine.component.html',
  styleUrls: ['./edit-fine.component.css']
})
export class EditFineComponent implements OnInit {

  @Input() modal!: any;
  @Input() finePost!: FinePost;

  public fineTitleFormControl!: FormControl;
  public fineTextFormControl!: FormControl;
  public finePostFormGroup!: FormGroup;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.setUpForm();
  }

  editPost(): void {
  }

  isNotChanged(): boolean {
    return (this.fineTextFormControl.value === this.finePost.fine.fineText &&
      this.fineTitleFormControl.value === this.finePost.fine.fineTitle);
  }

  setUpForm(): void {
    this.fineTitleFormControl = new FormControl(this.finePost.fine.fineTitle,
      [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(50)
      ]);

    this.fineTextFormControl = new FormControl(this.finePost.fine.fineText,
      [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(255)
      ]);

    this.finePostFormGroup = this.formBuilder.group({
      fineTitle: this.fineTitleFormControl,
      fineText: this.fineTextFormControl
    });
  }
}
