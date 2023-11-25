import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { CheckSheetModalComponent } from './check-sheet-modal.component';
import { OriginHandlingAgentSheetComponentModule } from '../../components/origin-handling-agent-sheet/origin-handling-agent-sheet.module';
import { PreparationSheetComponentModule } from '../../components/preparation-sheet/preparation-sheet.module';
import { InboundTransitSheetComponentModule } from '../../components/inbound-transit-sheet/inbound-transit-sheet.module';
import { DestinationHandlingAgentSheetComponentModule } from '../../components/destination-handling-agent-sheet/destination-handling-agent-sheet.module';
import { OutboundTransitSheetComponentModule } from '../../components/outbound-transit-sheet copy/outbound-transit-sheet.module';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    OriginHandlingAgentSheetComponentModule,
    PreparationSheetComponentModule,
    InboundTransitSheetComponentModule,
    OutboundTransitSheetComponentModule,
    DestinationHandlingAgentSheetComponentModule,
  ],
  declarations: [CheckSheetModalComponent],
  exports: [CheckSheetModalComponent],
})
export class CheckSheetModalComponentModule {}
