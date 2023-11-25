import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { PreparationSheetComponent } from './preparation-sheet.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule, ReactiveFormsModule],
  declarations: [PreparationSheetComponent],
  exports: [PreparationSheetComponent],
})
export class PreparationSheetComponentModule {}
