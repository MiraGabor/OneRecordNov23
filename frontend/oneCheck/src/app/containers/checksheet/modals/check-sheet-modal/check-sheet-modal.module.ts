import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { CheckSheetModalComponent } from './check-sheet-modal.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule],
  declarations: [CheckSheetModalComponent],
  exports: [CheckSheetModalComponent],
})
export class CheckSheetModalComponentModule {}