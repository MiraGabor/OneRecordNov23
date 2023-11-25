import { Injectable } from '@angular/core';
import { State } from '@ngxs/store';

export interface CheckSheetStateModel {
  checkSheets: string[];
}

@State<CheckSheetStateModel>({
  name: 'checksheets',
  defaults: {
    checkSheets: ['test', 'test2'],
  },
})
@Injectable()
export class CheckSheetState {}
