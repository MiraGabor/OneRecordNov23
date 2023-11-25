import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { OriginHandlingAgentSheetComponent } from './origin-handling-agent-sheet.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule],
  declarations: [OriginHandlingAgentSheetComponent],
  exports: [OriginHandlingAgentSheetComponent],
})
export class OriginHandlingAgentSheetComponentModule {}
