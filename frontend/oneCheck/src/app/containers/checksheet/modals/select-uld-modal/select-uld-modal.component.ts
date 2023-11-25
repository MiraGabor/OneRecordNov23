import { Component } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { ShipmentDto } from 'src/model/shipmentDto';
import { ChecksheetStateSelectors } from '../../state/checksheet.selectors';
import { ChecksheetActions } from '../../state/checksheet.actions';
import { CheckSheetModalComponent } from '../check-sheet-modal/check-sheet-modal.component';
import { SheetDto } from 'src/model/sheetDto';

@Component({
  selector: 'app-select-uld-modal',
  templateUrl: './select-uld-modal.component.html',
  styleUrls: ['./select-uld-modal.component.scss'],
})
export class SelectUldModalComponent {
  public shipment$: Observable<ShipmentDto | undefined> = this.store.select(
    ChecksheetStateSelectors.shipment
  );

  public constructor(
    private modalCtrl: ModalController,
    private store: Store
  ) {}

  public async dismissModal(): Promise<void> {
    await this.modalCtrl.dismiss();
  }

  public getChecksheet(uldId: string): void {
    this.store
      .dispatch(new ChecksheetActions.getChecksheet(uldId))
      .subscribe(async () => {
        const checksheet = this.store.selectSnapshot(
          ChecksheetStateSelectors.preparationChecksheetByUldNumber(uldId)
        );

        const checksheetModal = await this.modalCtrl.create({
          component: CheckSheetModalComponent,
          componentProps: { checksheet: checksheet, checksheetId: 'todo' }, // todo doublecheck here
        });

        await checksheetModal.present();
      });
  }
}
