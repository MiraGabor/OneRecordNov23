import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ScanPage } from './scan.page';

const routes: Routes = [
  {
    path: '',
    component: ScanPage,
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  declarations: [],
  exports: [RouterModule],
})
export class ScanPageRoutingModule {}
