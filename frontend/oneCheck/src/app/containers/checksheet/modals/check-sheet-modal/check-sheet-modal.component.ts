import { Component, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { ChecksheetActions } from '../../state/checksheet.actions';

@Component({
  selector: 'app-check-sheet-modal',
  templateUrl: './check-sheet-modal.component.html',
  styleUrls: ['./check-sheet-modal.component.scss'],
})
export class CheckSheetModalComponent implements OnInit {
  public constructor(
    private modalCtrl: ModalController,
    private store: Store
  ) {}

  public activeSegment = 'export'; // todo chose via role

  public ngOnInit() {}

  public async dismissModal(): Promise<void> {
    await this.modalCtrl.dismiss();
  }

  public submitChecksheet(): void {
    this.store.dispatch(new ChecksheetActions.submitChecksheet());
  }

  public changeSegment(ev: any): void {
    console.log('segment change', ev.detail.value);
    this.activeSegment = ev.detail.value;
  }
}
