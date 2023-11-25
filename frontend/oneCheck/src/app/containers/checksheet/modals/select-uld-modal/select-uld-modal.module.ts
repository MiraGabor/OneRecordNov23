import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { SelectUldModalComponent } from './select-uld-modal.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule],
  declarations: [SelectUldModalComponent],
  exports: [SelectUldModalComponent],
})
export class SelectUldModalComponentModule {}
