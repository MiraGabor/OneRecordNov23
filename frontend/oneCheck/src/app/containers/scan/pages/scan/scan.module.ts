import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { ScanPage } from './scan.page';

import { LoginMaskComponentModule } from 'src/app/containers/user/components/login-mask/login-mask.module';
import { ScanPageRoutingModule } from './scan-routing.module';
import { SelectRoleComponentModule } from 'src/app/containers/user/components/select-role/select-role.module';
import { CheckSheetModalComponentModule } from 'src/app/containers/checksheet/modals/check-sheet-modal/check-sheet-modal.module';
import { SelectUldModalComponentModule } from 'src/app/containers/checksheet/modals/select-uld-modal/select-uld-modal.module';

@NgModule({
  imports: [
    IonicModule,
    CommonModule,
    FormsModule,
    ScanPageRoutingModule,
    LoginMaskComponentModule,
    SelectRoleComponentModule,
    CheckSheetModalComponentModule,
    SelectUldModalComponentModule,
  ],
  declarations: [ScanPage],
})
export class Tab1PageModule {}
