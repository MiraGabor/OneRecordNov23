import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { InboundTransitSheetComponent } from './inbound-transit-sheet.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule, ReactiveFormsModule],
  declarations: [InboundTransitSheetComponent],
  exports: [InboundTransitSheetComponent],
})
export class InboundTransitSheetComponentModule {}
