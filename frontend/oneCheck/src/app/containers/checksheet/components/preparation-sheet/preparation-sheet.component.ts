import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';
import { OriginPreparationSheetDto } from 'src/model/originPreparationSheetDto';

@Component({
  selector: 'app-preparation-sheet',
  templateUrl: './preparation-sheet.component.html',
  styleUrls: ['./preparation-sheet.component.scss'],
})
export class PreparationSheetComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;
  public canEdit = false;

  public form: FormGroup = new FormGroup({
    checkSheetId: new FormControl(''),
    date: new FormControl('', Validators.required),
    time: new FormControl('', Validators.required),
    sealNumber: new FormControl(''),
    // signature: new FormControl(''),
    name: new FormControl(''),
    batteryStatusInPercent: new FormControl(''),
    uldNumber: new FormControl(''),
    awbNumber: new FormControl(''),
    isBatteryCharged: new FormControl(''),
    isContainerDamaged: new FormControl(''),
    routing: new FormControl(''),
    goodsPrecooledAtTemps: new FormControl(''),
    uldPrecooledTemp: new FormControl(''),
    tempSetting: new FormControl(''),
    acceptedTempRange: new FormControl(''),
    emergencyPhone: new FormControl(''),
  });

  @Input() public preparationSheet: OriginPreparationSheetDto | undefined;

  constructor(private store: Store) {}

  public ngOnInit(): void {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      this.canEdit = role === 'export'; // todo rename role
    });

    // pre-fill sheet
    if (this.preparationSheet) {
      this.form.patchValue(this.preparationSheet); // todo does this work?
    }
  }

  public onSubmit() {
    console.log(this.form?.value);
  }
}
