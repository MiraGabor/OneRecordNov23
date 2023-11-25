import { Component, Input, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { ChecksheetActions } from '../../state/checksheet.actions';
import { SheetDto } from 'src/model/sheetDto';

@Component({
  selector: 'app-check-sheet-modal',
  templateUrl: './check-sheet-modal.component.html',
  styleUrls: ['./check-sheet-modal.component.scss'],
})
export class CheckSheetModalComponent implements OnInit {
  @Input() public checksheet: SheetDto | undefined;
  @Input() public checksheetId: string | undefined;

  public constructor(
    private modalCtrl: ModalController,
    private store: Store
  ) {}

  public activeSegment = 'export'; // todo chose via role // todo change to origin?

  public ngOnInit() {
    console.log(this.checksheet);
  }

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
