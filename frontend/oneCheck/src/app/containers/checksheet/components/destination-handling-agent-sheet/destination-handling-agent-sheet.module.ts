import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { DestinationHandlingAgentSheetComponent } from './destination-handling-agent-sheet.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule, ReactiveFormsModule],
  declarations: [DestinationHandlingAgentSheetComponent],
  exports: [DestinationHandlingAgentSheetComponent],
})
export class DestinationHandlingAgentSheetComponentModule {}
