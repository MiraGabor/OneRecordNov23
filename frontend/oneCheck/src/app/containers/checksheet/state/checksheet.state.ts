import { Injectable } from '@angular/core';
import { Action, State, StateContext } from '@ngxs/store';
import { ChecksheetActions } from './checksheet.actions';
import { Observable, of, tap } from 'rxjs';
import { ScanService } from '../../scan/services/scan.service';

export interface CheckSheetStateModel {
  checkSheets: string[];
  ulds: string[];
}

@State<CheckSheetStateModel>({
  name: 'checksheets',
  defaults: {
    checkSheets: ['test', 'test2'],
    ulds: [],
  },
})
@Injectable()
export class CheckSheetState {
  public constructor(private scanService: ScanService) {}

  // send shipment code and receive all ULD codes
  @Action(ChecksheetActions.getULDs)
  public login(
    ctx: StateContext<CheckSheetStateModel>,
    action: ChecksheetActions.getULDs
  ): Observable<any> {
    // todo type
    const state = ctx.getState();

    return this.scanService.getULDs('1234').pipe(
      tap((result) => {
        console.log(result);
      })
    );
  }
}
