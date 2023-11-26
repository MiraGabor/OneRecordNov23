import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { DestinationHandlingAgentSheetDto } from 'src/model/destinationHandlingAgentSheetDto';
import { ChecksheetActions } from '../../state/checksheet.actions';

@Component({
  selector: 'app-destination-handling-agent-sheet',
  templateUrl: './destination-handling-agent-sheet.component.html',
  styleUrls: ['./destination-handling-agent-sheet.component.scss'],
})
export class DestinationHandlingAgentSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;
  public canEdit = false;

  public isSubmitting = false;

  @Output()
  submitted = new EventEmitter<boolean>();

  public form: FormGroup = new FormGroup({
    checkSheetId: new FormControl(''),
    date: new FormControl(''),
    time: new FormControl(''),
    sealNumber: new FormControl(''),
    //signature: new FormControl(''),
    name: new FormControl(''),
    batteryStatusInPercent: new FormControl(''),
    inboundCheckAirport: new FormControl(''),
    isContainerOperating: new FormControl(''),
    isContainerDamaged: new FormControl(''),
    displayedTemp: new FormControl(''),
    inboundCheckAirportCode: new FormControl(''),
    blueLight: new FormControl(''),
    isAlarmDisplayed: new FormControl(''),
    setTempOnDisplay: new FormControl(''),
  });

  @Input() public destinationHandlingAgentSheet:
    | DestinationHandlingAgentSheetDto
    | null
    | undefined;

  constructor(private store: Store) {}

  public ngOnInit(): void {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      if (role !== 'import') {
        this.form.disable();
      }
    });

    // pre-fill sheet
    if (this.destinationHandlingAgentSheet) {
      this.form.patchValue(this.destinationHandlingAgentSheet);

      this.form.patchValue({
        date: '2023-11-28',
        time: '09:00',
        name: 'Dante Favero',
      });
    }
  }

  public onSubmit() {
    const checksheet: DestinationHandlingAgentSheetDto = this.form?.value;
    this.isSubmitting = true;

    this.store
      .dispatch(new ChecksheetActions.submiDestinationHandlingSheet(checksheet))
      .subscribe(() => {
        this.isSubmitting = false;
        this.submitted.emit(true);
      });
  }
}
