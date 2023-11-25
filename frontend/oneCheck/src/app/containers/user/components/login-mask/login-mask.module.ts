import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { IonicModule } from '@ionic/angular';
import { LoginMaskComponent } from './login-mask.component';

@NgModule({
  imports: [CommonModule, FormsModule, IonicModule],
  declarations: [LoginMaskComponent],
  exports: [LoginMaskComponent],
})
export class LoginMaskComponentModule {}
