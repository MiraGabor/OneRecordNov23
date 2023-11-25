import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { SelectRoleComponentModule } from 'src/app/containers/user/components/select-role/select-role.module';
import { SettingsPageRoutingModule } from './settings-routing.module';
import { SettingsPage } from './settings.page';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    SettingsPageRoutingModule,
    SelectRoleComponentModule,
  ],
  declarations: [SettingsPage],
})
export class SettingsPageModule {}
