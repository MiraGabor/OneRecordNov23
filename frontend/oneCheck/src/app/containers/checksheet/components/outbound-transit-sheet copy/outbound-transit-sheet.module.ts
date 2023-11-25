import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { OutboundTransitSheetComponent } from './outbound-transit-sheet.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule, ReactiveFormsModule],
  declarations: [OutboundTransitSheetComponent],
  exports: [OutboundTransitSheetComponent],
})
export class OutboundTransitSheetComponentModule {}
