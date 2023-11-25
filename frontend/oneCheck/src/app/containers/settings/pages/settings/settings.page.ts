import { Component, OnInit } from '@angular/core';
import { AlertController } from '@ionic/angular';
import { Store } from '@ngxs/store';
import { Observable } from 'rxjs';
import { UserActions } from 'src/app/containers/user/state/user.actions';
import { UserStateSelectors } from 'src/app/containers/user/state/user.selectors';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.page.html',
  styleUrls: ['./settings.page.scss'],
})
export class SettingsPage implements OnInit {
  public userLoggedIn$: Observable<boolean> | undefined;
  public userRole$: Observable<string | undefined> | undefined;

  public constructor(
    private store: Store,
    private alertCtrl: AlertController
  ) {}

  public ngOnInit() {
    this.userLoggedIn$ = this.store.select(UserStateSelectors.userLoggedIn);
    this.userRole$ = this.store.select(UserStateSelectors.userRole);
  }

  public async logout(): Promise<void> {
    const alert = await this.alertCtrl.create({
      header: 'Logout Successful',
      buttons: ['Close'],
    });

    this.store.dispatch(UserActions.Logout).subscribe(() => {
      alert.present();
    });
  }
}
