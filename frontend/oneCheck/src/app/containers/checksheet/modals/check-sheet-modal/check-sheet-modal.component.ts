import { Component, Input, OnInit } from '@angular/core';
import { ModalController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { ChecksheetActions } from '../../state/checksheet.actions';
import { SheetDto } from 'src/model/sheetDto';
import { Observable } from 'rxjs';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';

@Component({
  selector: 'app-check-sheet-modal',
  templateUrl: './check-sheet-modal.component.html',
  styleUrls: ['./check-sheet-modal.component.scss'],
})
export class CheckSheetModalComponent implements OnInit {
  public userRole$: Observable<string | undefined> | undefined;
  public userRole = '';

  @Input() public checksheet: SheetDto | undefined;
  @Input() public checksheetId: string | undefined;

  public constructor(
    private modalCtrl: ModalController,
    private store: Store
  ) {}

  public activeSegment = 'export'; // todo chose via role // todo change to origin?

  public ngOnInit() {
    this.userRole$ = this.store.select(UserStateSelectors.userRole);

    this.userRole$.subscribe((role) => {
      if (role) {
        this.activeSegment = role as string; // not typesafe..
        this.userRole = role;
      }
    });
  }

  public async dismissModal(): Promise<void> {
    await this.modalCtrl.dismiss();
  }

  public submitChecksheet(): void {
    this.store.dispatch(new ChecksheetActions.submitChecksheet());
  }

  public changeSegment(ev: any): void {
    this.activeSegment = ev.detail.value;
  }
}
