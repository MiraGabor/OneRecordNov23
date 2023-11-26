import { DatePipe } from '@angular/common';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { OriginHandlingAgentSheetDto } from 'src/model/originHandlingAgentSheetDto';
import { ChecksheetActions } from '../../state/checksheet.actions';

@Component({
  selector: 'app-origin-handling-agent-sheet',
  templateUrl: './origin-handling-agent-sheet.component.html',
  styleUrls: ['./origin-handling-agent-sheet.component.scss'],
})
export class OriginHandlingAgentSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;

  public canEdit = true;
  public isSubmitting = false;

  @Output()
  submitted = new EventEmitter<boolean>();

  public form: FormGroup = new FormGroup({
    //checkSheetId: new FormControl('', Validators.required), // todo hide in UI?
    date: new FormControl('', Validators.required),
    time: new FormControl('', Validators.required),
    sealNumber: new FormControl('', Validators.required),
    //signature: new FormControl('', Validators.required), // todo hide in UI?
    name: new FormControl('', Validators.required),
    batteryStatusInPercent: new FormControl('', Validators.required),
    isContainerDamaged: new FormControl('', Validators.required),
    isContainerOperating: new FormControl('', Validators.required),
    displayTemp: new FormControl('', Validators.required),
    isAlert: new FormControl('', Validators.required),
    isBlueLightOn: new FormControl('', Validators.required),
    alertDisplayed: new FormControl('', Validators.required),
    setTempOnDisplay: new FormControl('', Validators.required),
    is5AdaptersPresents: new FormControl('', Validators.required),
  });

  @Input() public originHandlingAgentSheet:
    | OriginHandlingAgentSheetDto
    | undefined;

  constructor(private store: Store) {}

  public ngOnInit(): void {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      console.log('lel', role);

      // todo station code
      if (role !== 'export') {
        this.canEdit = false;
        this.form.disable();
      }
    });

    // pre-fill sheet
    if (this.originHandlingAgentSheet) {
      this.form.patchValue(this.originHandlingAgentSheet); // todo does this work?

      this.form.patchValue({
        date: '2023-11-26', // replace with the value you want to set
        time: '09:00',
      });
    }
  }

  public onSubmit() {
    console.log(this.form?.value);
    this.isSubmitting = true;
    this.form.disable();

    const checkcheet: OriginHandlingAgentSheetDto = this.form?.value;
    this.store
      .dispatch(new ChecksheetActions.submitOriginHandlingSheet(checkcheet))
      .subscribe(() => {
        this.isSubmitting = false;
        this.submitted.emit(true);
      });
  }
}
