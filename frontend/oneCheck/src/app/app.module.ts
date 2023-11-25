import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';
import { IonicModule, IonicRouteStrategy } from '@ionic/angular';
import { NgxsReduxDevtoolsPluginModule } from '@ngxs/devtools-plugin';
import { NgxsModule } from '@ngxs/store';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CheckSheetState } from './containers/checksheet/state/checksheet.state';
import { BarcodeScanningModalComponent } from './containers/scan/modals/scanner-modal/scanner-modal.component';
import { UserState } from './containers/user/state/user.state';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [AppComponent, BarcodeScanningModalComponent],
  imports: [
    BrowserModule,
    IonicModule.forRoot(),
    AppRoutingModule,
    NgxsModule.forRoot([CheckSheetState, UserState], {
      developmentMode: true, // todo
    }),
    NgxsReduxDevtoolsPluginModule.forRoot(),
    HttpClientModule,
  ],
  providers: [{ provide: RouteReuseStrategy, useClass: IonicRouteStrategy }],
  bootstrap: [AppComponent],
})
export class AppModule {}
