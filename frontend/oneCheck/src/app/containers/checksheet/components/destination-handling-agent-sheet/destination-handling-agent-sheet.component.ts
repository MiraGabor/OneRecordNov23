import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { DestinationHandlingAgentSheetDto } from 'src/model/destinationHandlingAgentSheetDto';

@Component({
  selector: 'app-destination-handling-agent-sheet',
  templateUrl: './destination-handling-agent-sheet.component.html',
  styleUrls: ['./destination-handling-agent-sheet.component.scss'],
})
export class DestinationHandlingAgentSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;
  public canEdit = false;

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
      this.form.patchValue(this.destinationHandlingAgentSheet); // todo does this work?
    }
  }

  public onSubmit() {
    console.log(this.form?.value);
  }
}
