import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { InboundTransitSheetDto } from 'src/model/inboundTransitSheetDto';
import { TransitCheckSheetDto } from 'src/model/transitCheckSheetDto';

@Component({
  selector: 'app-inbound-transit-sheet',
  templateUrl: './inbound-transit-sheet.component.html',
  styleUrls: ['./inbound-transit-sheet.component.scss'],
})
export class InboundTransitSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;

  public form: FormGroup = new FormGroup({
    checkSheetId: new FormControl(''),
    date: new FormControl('', Validators.required),
    time: new FormControl(''),
    sealNumber: new FormControl(''),
    signature: new FormControl(''),
    name: new FormControl(''),
    batteryStatusInPercent: new FormControl(''),
    isContainerOperating: new FormControl(''),
    isContainerDamaged: new FormControl(''),
    displayedTemp: new FormControl(''),
    inboundCheckAirportCode: new FormControl(''),
    blueLight: new FormControl(''),
    isAlarmDisplayed: new FormControl(''),
  });

  @Input() public inboundTransitCheckSheet: InboundTransitSheetDto | undefined;

  constructor(private store: Store) {}

  public ngOnInit(): void {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      // todo check station Code
      if (role !== 'transit') {
        this.form.disable();
      }
    });

    // pre-fill sheet
    if (this.inboundTransitCheckSheet) {
      this.form.patchValue(this.inboundTransitCheckSheet); // todo does this work?
    }
  }

  public onSubmit() {
    console.log(this.form?.value);
  }
}
