import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { SelectRoleComponent } from './select-role.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule],
  declarations: [SelectRoleComponent],
  exports: [SelectRoleComponent],
})
export class SelectRoleComponentModule {}
